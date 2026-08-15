using MunicipalServicesApp.Models;
using System;
using MunicipalServicesApp.Data;
using System.IO;
using System.Windows.Forms;

namespace MunicipalServicesApp.Forms
{
    public partial class ReportIssueForm : Form
    {
        // ==============================
        // FORM DATA
        // ==============================

        private string attachmentPath = string.Empty;

        public ReportIssueForm()
        {
            InitializeComponent();

            LoadCategories();
            UpdateProgress();
        }

        // ==============================
        // CATEGORY SETUP
        // ==============================

        private void LoadCategories()
        {
            cmbCategory.Items.Add("Sanitation");
            cmbCategory.Items.Add("Roads");
            cmbCategory.Items.Add("Water");
            cmbCategory.Items.Add("Electricity");
            cmbCategory.Items.Add("Waste Management");
            cmbCategory.Items.Add("Other");

            cmbCategory.SelectedIndex = -1;
        }

        // ==============================
        // FORM PROGRESS
        // ==============================

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void UpdateProgress()
        {
            int completed = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                completed++;

            if (cmbCategory.SelectedIndex >= 0)
                completed++;

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
                completed++;

            progressReport.Value = completed;

            switch (completed)
            {
                case 0:
                    lblProgress.Text = "Complete the form to continue";
                    break;

                case 1:
                    lblProgress.Text = "Good start!";
                    break;

                case 2:
                    lblProgress.Text = "Almost there!";
                    break;

                case 3:
                    lblProgress.Text = "You're ready to submit!";
                    break;
            }
        }

        // ==============================
        // FILE ATTACHMENT
        // ==============================

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Attach Supporting File";
                dialog.Filter =
                    "Images and Documents|*.jpg;*.jpeg;*.png;*.pdf;*.doc;*.docx|All Files|*.*";

                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    attachmentPath = dialog.FileName;
                    lblfile.Text = Path.GetFileName(attachmentPath);
                }
            }
        }

        // ==============================
        // ISSUE SUBMISSION
        // ==============================

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show(
                    "Please enter the location of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLocation.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an issue category.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show(
                    "Please provide a description of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                rtbDescription.Focus();
                return;
            }

            Issue issue = new Issue
            {
                Id = IssueRepository.Issues.Count + 1,
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text.Trim(),
                AttachmentPath = attachmentPath,
                DateReported = DateTime.Now
            };

            IssueRepository.Issues.Add(issue);

            MessageBox.Show(
                "Your issue has been submitted successfully!\n\n" +
                "Thank you for helping improve your community.",
                "Issue Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
        }

        // ==============================
        // CLEAR FORM
        // ==============================

        private void ClearForm()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();

            attachmentPath = string.Empty;
            lblAttachment.Text = "No file attached";

            progressReport.Value = 0;
            lblProgress.Text = "Complete the form to continue";
        }
    }
}