using MunicipalServicesApp.Forms;
using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainForm : Form
    {
        private ReportIssueForm reportIssueForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            OpenReportIssueForm();
        }

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

        private void ShowDashboard()
        {
            if (reportIssueForm != null)
            {
                reportIssueForm.Hide();
            }

            ShowDashboardControls();
        }

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
    }
}