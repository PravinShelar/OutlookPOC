namespace OutlookPOC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOutlookMail = new System.Windows.Forms.GroupBox();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAttachments = new System.Windows.Forms.ListView();
            this.cbMsgFile = new System.Windows.Forms.CheckBox();
            this.btnLoadMsgFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.gbOutlookMail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOutlookMail
            // 
            this.gbOutlookMail.Controls.Add(this.tbBody);
            this.gbOutlookMail.Controls.Add(this.label4);
            this.gbOutlookMail.Controls.Add(this.lbCount);
            this.gbOutlookMail.Controls.Add(this.label1);
            this.gbOutlookMail.Controls.Add(this.label2);
            this.gbOutlookMail.Controls.Add(this.label3);
            this.gbOutlookMail.Controls.Add(this.lbSubject);
            this.gbOutlookMail.Controls.Add(this.lbTo);
            this.gbOutlookMail.Location = new System.Drawing.Point(78, 232);
            this.gbOutlookMail.Name = "gbOutlookMail";
            this.gbOutlookMail.Size = new System.Drawing.Size(690, 304);
            this.gbOutlookMail.TabIndex = 1;
            this.gbOutlookMail.TabStop = false;
            this.gbOutlookMail.Text = "Outlook Mail";
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(28, 160);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbBody.Size = new System.Drawing.Size(646, 124);
            this.tbBody.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "No of Attachments :";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(143, 87);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(35, 13);
            this.lbCount.TabIndex = 6;
            this.lbCount.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Body :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To :";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(142, 55);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(43, 13);
            this.lbSubject.TabIndex = 1;
            this.lbSubject.Text = "Subject";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(142, 27);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(20, 13);
            this.lbTo.TabIndex = 0;
            this.lbTo.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(78, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drop Target";
            this.groupBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragDrop);
            this.groupBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragEnter);
            this.groupBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragOver);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(681, 703);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(570, 705);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAttachments);
            this.groupBox2.Location = new System.Drawing.Point(78, 554);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 143);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attachments";
            // 
            // lstAttachments
            // 
            this.lstAttachments.Location = new System.Drawing.Point(39, 23);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(635, 97);
            this.lstAttachments.TabIndex = 5;
            this.lstAttachments.UseCompatibleStateImageBehavior = false;
            // 
            // cbMsgFile
            // 
            this.cbMsgFile.AutoSize = true;
            this.cbMsgFile.Location = new System.Drawing.Point(84, 12);
            this.cbMsgFile.Name = "cbMsgFile";
            this.cbMsgFile.Size = new System.Drawing.Size(109, 17);
            this.cbMsgFile.TabIndex = 7;
            this.cbMsgFile.Text = "Outlook.MSG File";
            this.cbMsgFile.UseVisualStyleBackColor = true;
            // 
            // btnLoadMsgFile
            // 
            this.btnLoadMsgFile.Location = new System.Drawing.Point(641, 13);
            this.btnLoadMsgFile.Name = "btnLoadMsgFile";
            this.btnLoadMsgFile.Size = new System.Drawing.Size(127, 23);
            this.btnLoadMsgFile.TabIndex = 8;
            this.btnLoadMsgFile.Text = "Load .MSG File";
            this.btnLoadMsgFile.UseVisualStyleBackColor = true;
            this.btnLoadMsgFile.Click += new System.EventHandler(this.btnLoadMsgFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "Drop here..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 745);
            this.Controls.Add(this.btnLoadMsgFile);
            this.Controls.Add(this.cbMsgFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbOutlookMail);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Outlook POC Window";
            this.gbOutlookMail.ResumeLayout(false);
            this.gbOutlookMail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOutlookMail;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstAttachments;
        private System.Windows.Forms.CheckBox cbMsgFile;
        private System.Windows.Forms.Button btnLoadMsgFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
    }
}

