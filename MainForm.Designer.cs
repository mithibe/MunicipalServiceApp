namespace SAMSA
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnLocalEventsAndAnnouncements = new System.Windows.Forms.Button();
            this.btnServiceRequestStatus = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportIssuesUserControl = new SAMSA.ReportIssuesUserControl();
            this.loginPage = new SAMSA.Login();
            this.localEventsUserControl = new SAMSA.LocalEventsUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Location = new System.Drawing.Point(43, 12);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(150, 50);
            this.btnReportIssues.TabIndex = 3;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnLocalEventsAndAnnouncements
            // 
            this.btnLocalEventsAndAnnouncements.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLocalEventsAndAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEventsAndAnnouncements.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalEventsAndAnnouncements.ForeColor = System.Drawing.Color.White;
            this.btnLocalEventsAndAnnouncements.Location = new System.Drawing.Point(43, 78);
            this.btnLocalEventsAndAnnouncements.Name = "btnLocalEventsAndAnnouncements";
            this.btnLocalEventsAndAnnouncements.Size = new System.Drawing.Size(150, 50);
            this.btnLocalEventsAndAnnouncements.TabIndex = 4;
            this.btnLocalEventsAndAnnouncements.Text = "Local Events and Announcements";
            this.btnLocalEventsAndAnnouncements.UseVisualStyleBackColor = false;
            this.btnLocalEventsAndAnnouncements.Click += new System.EventHandler(this.btnLocalEventsAndAnnouncements_Click);
            // 
            // btnServiceRequestStatus
            // 
            this.btnServiceRequestStatus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnServiceRequestStatus.Enabled = false;
            this.btnServiceRequestStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceRequestStatus.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceRequestStatus.ForeColor = System.Drawing.Color.White;
            this.btnServiceRequestStatus.Location = new System.Drawing.Point(43, 141);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new System.Drawing.Size(150, 50);
            this.btnServiceRequestStatus.TabIndex = 5;
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gold;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(43, 435);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReportIssues);
            this.panel1.Controls.Add(this.btnLocalEventsAndAnnouncements);
            this.panel1.Controls.Add(this.btnServiceRequestStatus);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 598);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.reportIssuesUserControl);
            this.panel2.Controls.Add(this.loginPage);
            this.panel2.Controls.Add(this.localEventsUserControl);
            this.panel2.Location = new System.Drawing.Point(262, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 573);
            this.panel2.TabIndex = 0;
            // 
            // reportIssuesUserControl
            // 
            this.reportIssuesUserControl.Location = new System.Drawing.Point(116, 63);
            this.reportIssuesUserControl.Name = "reportIssuesUserControl";
            this.reportIssuesUserControl.Size = new System.Drawing.Size(795, 480);
            this.reportIssuesUserControl.TabIndex = 2;
            this.reportIssuesUserControl.Visible = false;
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.White;
            this.loginPage.Location = new System.Drawing.Point(266, 122);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(400, 350);
            this.loginPage.TabIndex = 1;
            this.loginPage.Visible = false;
            // 
            // localEventsUserControl
            // 
            this.localEventsUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.localEventsUserControl.Location = new System.Drawing.Point(30, 63);
            this.localEventsUserControl.Name = "localEventsUserControl";
            this.localEventsUserControl.Size = new System.Drawing.Size(935, 409);
            this.localEventsUserControl.TabIndex = 0;
            this.localEventsUserControl.Visible = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1220, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private LocalEventsUserControl localEventsUserControl;
        private Login loginPage;
        private ReportIssuesUserControl reportIssuesUserControl;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnLocalEventsAndAnnouncements;
        private System.Windows.Forms.Button btnServiceRequestStatus;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}