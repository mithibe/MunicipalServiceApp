using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMSA
{
    public partial class ReportIssuesForm : Form
    {
        public ReportIssuesForm()
        {
            InitializeComponent();
            // Initially hide the PictureBox and Label used for preview
            pictureBoxPreview.Visible = false;
            lblFilePreview.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;|Document Files|*.pdf;*.docx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Attach the file
                string filePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png")
                {
                    // If the file is an image, display it in the PictureBox
                    pictureBoxPreview.Image = Image.FromFile(filePath);
                    pictureBoxPreview.Visible = true;
                    lblFilePreview.Visible=false; // Hide the label if image is shown
                }
                else
                {
                    // If it's a document, show the file name and path in a label
                    lblFilePreview.Text = $"Attched file: {Path.GetFileName(filePath)}";
                    lblFilePreview.Visible = true;
                    pictureBoxPreview.Visible = false; // Hide the picture box for documents
                }
                // Process the file (e.g., store the file path)
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Collect issue details
            string location = txtLocation.Text;
            string category = cboCategory.SelectedItem.ToString();
            string description = rtbDescription.Text;

            // Implement logic to save data in appropriate data structures
            Issue issue = new Issue(location, category, description);
            IssueStorage.Add(issue);

            // Show confirmation or progress
            MessageBox.Show("Issue submitted successfully!");
            this.Close();
        }
    }

    // Sample data structure to store issues
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Issue(string location, string category, string description)
        {
            Location = location;
            Category = category;
            Description = description;
        }
    }

    // In-memory storage (for now)
    public static class IssueStorage
    {
        public static List<Issue> Issues = new List<Issue>();

        public static void Add(Issue issue)
        {
            Issues.Add(issue);
        }
    }
}
