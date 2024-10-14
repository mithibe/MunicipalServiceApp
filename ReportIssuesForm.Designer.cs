namespace SAMSA
{
    partial class ReportIssuesForm
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.lblFilePreview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(12, 25);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 0;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(12, 64);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 21);
            this.cboCategory.TabIndex = 1;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(12, 104);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(382, 244);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.Location = new System.Drawing.Point(503, 64);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(75, 23);
            this.btnAttachMedia.TabIndex = 3;
            this.btnAttachMedia.Text = "Attach File";
            this.btnAttachMedia.UseVisualStyleBackColor = true;
            this.btnAttachMedia.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(426, 104);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(220, 255);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 8;
            this.pictureBoxPreview.TabStop = false;
            // 
            // lblFilePreview
            // 
            this.lblFilePreview.AutoSize = true;
            this.lblFilePreview.Location = new System.Drawing.Point(423, 104);
            this.lblFilePreview.Name = "lblFilePreview";
            this.lblFilePreview.Size = new System.Drawing.Size(35, 13);
            this.lblFilePreview.TabIndex = 9;
            this.lblFilePreview.Text = "label4";
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.lblFilePreview);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtLocation);
            this.Name = "ReportIssuesForm";
            this.Text = "ReportIssuesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label lblFilePreview;
    }
}