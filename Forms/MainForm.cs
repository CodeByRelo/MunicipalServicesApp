using MunicipalServicesApp.Data;
using MunicipalServicesApp.Forms;
using MunicipalServicesApp.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainForm : Form
    {
        private ReportIssueForm reportIssueForm;

        public MainForm()
        {
            InitializeComponent();

            LoadRecentReports();
        }

        // ==============================
        // SIDEBAR NAVIGATION
        // ==============================

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            OpenReportIssueForm();
        }

        // ==============================
        // DASHBOARD REPORT BUTTONS
        // ==============================

        private void btnHeroReport_Click(object sender, EventArgs e)
        {
            OpenReportIssueForm();
        }

        private void pnlQuickReport_Click(object sender, EventArgs e)
        {
            OpenReportIssueForm();
        }

        private void lblQuickReportSub_Click(object sender, EventArgs e)
        {
            OpenReportIssueForm();
        }

        // ==============================
        // OPEN REPORT ISSUE FORM
        // ==============================

        private void OpenReportIssueForm()
        {
            if (reportIssueForm == null)
            {
                reportIssueForm = new ReportIssueForm();

                reportIssueForm.TopLevel = false;
                reportIssueForm.FormBorderStyle = FormBorderStyle.None;
                reportIssueForm.Dock = DockStyle.Fill;

                pnlContent.Controls.Add(reportIssueForm);
            }

            HideDashboard();

            reportIssueForm.Show();
            reportIssueForm.BringToFront();
        }

        // ==============================
        // SHOW DASHBOARD
        // ==============================

        private void ShowDashboard()
        {
            if (reportIssueForm != null)
            {
                reportIssueForm.Hide();
            }

            ShowDashboardControls();

            LoadRecentReports();
        }

        // ==============================
        // HIDE DASHBOARD CONTROLS
        // ==============================

        private void HideDashboard()
        {
            foreach (Control control in pnlContent.Controls)
            {
                if (control != reportIssueForm)
                {
                    control.Visible = false;
                }
            }
        }

        // ==============================
        // SHOW DASHBOARD CONTROLS
        // ==============================

        private void ShowDashboardControls()
        {
            foreach (Control control in pnlContent.Controls)
            {
                if (control != reportIssueForm)
                {
                    control.Visible = true;
                }
            }
        }

        // ==============================
        // RECENT REPORTS
        // ==============================

        private void LoadRecentReports()
        {
            flpRecentReports.Controls.Clear();

            if (IssueRepository.Issues.Count == 0)
            {
                AddEmptyReportsMessage();
                return;
            }

            // Display newest reports first.
            for (int i = IssueRepository.Issues.Count - 1; i >= 0; i--)
            {
                Issue issue = IssueRepository.Issues[i];

                Panel reportCard = CreateReportCard(issue);

                flpRecentReports.Controls.Add(reportCard);
            }
        }

        // ==============================
        // EMPTY REPORT MESSAGE
        // ==============================

        private void AddEmptyReportsMessage()
        {
            Label emptyLabel = new Label();

            emptyLabel.Text = "No reports submitted yet.";
            emptyLabel.Font = new Font("Segoe UI", 9F);
            emptyLabel.ForeColor = Color.FromArgb(153, 153, 153);
            emptyLabel.AutoSize = true;
            emptyLabel.Margin = new Padding(5, 10, 5, 10);

            flpRecentReports.Controls.Add(emptyLabel);
        }

        // ==============================
        // CREATE REPORT CARD
        // ==============================

        private Panel CreateReportCard(Issue issue)
        {
            Panel card = new Panel();

            card.Width = flpRecentReports.ClientSize.Width - 20;
            card.Height = 90;

            card.BackColor = Color.FromArgb(249, 249, 249);
            card.Margin = new Padding(0, 0, 0, 10);
            card.Padding = new Padding(15);

            // Category
            Label lblCategory = new Label();

            lblCategory.Text = issue.Category.ToUpper();
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(255, 122, 0);
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 12);

            // Date
            Label lblDate = new Label();

            lblDate.Text = issue.DateReported.ToString("dd MMM yyyy");
            lblDate.Font = new Font("Segoe UI", 8F);
            lblDate.ForeColor = Color.FromArgb(153, 153, 153);
            lblDate.AutoSize = true;
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            lblDate.Location = new Point(
                card.Width - lblDate.PreferredWidth - 15,
                14);

            // Description
            Label lblDescription = new Label();

            lblDescription.Text = issue.Description;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(23, 23, 23);
            lblDescription.AutoSize = false;
            lblDescription.Width = card.Width - 30;
            lblDescription.Height = 22;
            lblDescription.Location = new Point(15, 35);

            // Location
            Label lblLocation = new Label();

            lblLocation.Text = issue.Location;
            lblLocation.Font = new Font("Segoe UI", 8F);
            lblLocation.ForeColor = Color.FromArgb(120, 120, 120);
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(15, 60);

            card.Controls.Add(lblCategory);
            card.Controls.Add(lblDate);
            card.Controls.Add(lblDescription);
            card.Controls.Add(lblLocation);

            return card;
        }
    }
}