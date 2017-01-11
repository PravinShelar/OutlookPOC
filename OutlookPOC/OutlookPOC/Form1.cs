using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using System.Diagnostics;
using System.IO;

namespace OutlookPOC
{
    public partial class Form1 : Form
    {
        const string defaultFolderPath = @"C:\OutlookPOC\";

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            // Enable drag/drop
            groupBox1.AllowDrop = true;
            bool exists = System.IO.Directory.Exists(defaultFolderPath);
            if (!exists)
            {
                System.IO.Directory.CreateDirectory(defaultFolderPath);
            }
            lstAttachments.View = System.Windows.Forms.View.List;
            SetControlsVisibility(false);
        }

        #endregion

        #region Private Methods

        private void groupBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (cbMsgFile.Checked)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                    ExtractDataFromMSGFile(filePaths);
                }

            }
            else
            {
                ApplicationClass app = new ApplicationClass();
                Selection sel = app.ActiveExplorer().Selection;
                if (sel != null)
                {
                    SetControlsVisibility(true);
                    foreach (var mailItem in sel)
                    {
                        MailItem mi = (MailItem)mailItem;
                        int attachmentCount = mi.Attachments.Count;
                        lbTo.Text = mi.To;
                        lbSubject.Text = mi.Subject;
                        tbBody.Text = mi.Body;
                        lbCount.Text = attachmentCount.ToString();

                        if (attachmentCount > 0)
                        {

                            foreach (Attachment item in mi.Attachments)
                            {
                                string fileName = defaultFolderPath + item.FileName;
                                item.SaveAsFile(fileName);
                                lstAttachments.Items.Add(new ListViewItem(fileName));
                            }
                        }
                        else
                        {
                            btnOpen.Visible = false;
                        }

                        string subject = mi.Subject.Replace(":", "");
                        mi.SaveAs(defaultFolderPath + "\\" + subject + ".msg", Microsoft.Office.Interop.Outlook.OlSaveAsType.olMSG);

                    }

                }
            }
        }

        private void groupBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void groupBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbTo.Text = string.Empty;
            lbSubject.Text = string.Empty;
            tbBody.Text = string.Empty;
            lbCount.Text = string.Empty;
            lstAttachments.Clear();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lstAttachments.FocusedItem != null)
            {
                string path = lstAttachments.Items[lstAttachments.FocusedItem.Index].Text;
                Process.Start(path);
            }
        }

        private void btnLoadMsgFile_Click(object sender, EventArgs e)
        {

            DialogResult msgFileSelectResult = this.openFileDialog1.ShowDialog();
            if (msgFileSelectResult == DialogResult.OK)
            {
                string[] msgFiles = this.openFileDialog1.FileNames;
                ExtractDataFromMSGFile(msgFiles);
            }

        }

        /// <summary>
        /// Method to set Visibility of controls
        /// </summary>
        /// <param name="IsVisible">Visibility of controls</param>
        private void SetControlsVisibility(bool IsVisible)
        {
            gbOutlookMail.Visible = groupBox2.Visible = btnOpen.Visible = btnClear.Visible = IsVisible;
        }

        /// <summary>
        /// Method to extract data from .MSG File
        /// </summary>
        /// <param name="msgFiles">Collection of .MSG Files</param>
        private void ExtractDataFromMSGFile(string[] msgFiles)
        {
            gbOutlookMail.Visible = true;
            groupBox2.Visible = true;
            btnClear.Visible = true;
            foreach (string msgfile in msgFiles)
            {
                Stream messageStream = File.Open(msgfile, FileMode.Open, FileAccess.Read);
                OutlookStorage.Message message = new OutlookStorage.Message(messageStream);
                messageStream.Close();

                int attachmentCount = message.Attachments.Count;
                lbTo.Text = string.Empty;

                foreach (OutlookStorage.Recipient recipient in message.Recipients)
                {
                    lbTo.Text += recipient.Type + ": " + recipient.Email + " ";
                }

                lbSubject.Text = message.Subject;
                tbBody.Text = message.BodyText;
                lbCount.Text = attachmentCount.ToString();

                if (attachmentCount > 0)
                {

                    btnOpen.Visible = true;
                    foreach (OutlookStorage.Attachment item in message.Attachments)
                    {
                        string fileName = defaultFolderPath + item.Filename;
                        // Download attachments from .msg file
                        byte[] attachBytes = item.Data;
                        FileStream attachStream = File.Create(fileName);
                        attachStream.Write(attachBytes, 0, attachBytes.Length);
                        attachStream.Close();

                        // Add path in ListView to open those file
                        lstAttachments.Items.Add(new ListViewItem(fileName));
                    }


                }


                message.Dispose();
            }
        }

        #endregion
    }
}
