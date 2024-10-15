using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMSA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Set the form to open maximized

            // Initalize user controls
            reportIssuesUserControl = new ReportIssuesUserControl();
            localEventsUserControl = new LocalEventsUserControl();

            // Add the user controls to the form's controls but keep them hidden initially
            reportIssuesUserControl.Visible = false;
            localEventsUserControl.Visible = false;
            this.Controls.Add(reportIssuesUserControl);
            this.Controls.Add(localEventsUserControl);
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            localEventsUserControl.Visible = false;
            reportIssuesUserControl.Visible = true;
        }

        private void btnLocalEventsAndAnnouncements_Click(object sender, EventArgs e)
        {
            // Hide report issues user control and show local events user control
            reportIssuesUserControl.Visible = false;
            localEventsUserControl.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Show login page and hide both user controls
            loginPage.Visible = true;
            localEventsUserControl.Visible = false;
            reportIssuesUserControl.Visible = false;
        }
    }
}
