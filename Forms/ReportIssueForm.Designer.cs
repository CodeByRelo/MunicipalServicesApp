namespace MunicipalServicesApp.Forms
{
    partial class ReportIssueForm
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tblReportLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlReportHeader = new System.Windows.Forms.Panel();
            this.lblReportSubtitle = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.lblReportInstructions = new System.Windows.Forms.Label();
            this.tblReportForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.pnlSubmit = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressReport = new System.Windows.Forms.ProgressBar();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlAttachment = new System.Windows.Forms.Panel();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lblfile = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.tblReportLayout.SuspendLayout();
            this.pnlReportHeader.SuspendLayout();
            this.tblReportForm.SuspendLayout();
            this.pnlSubmit.SuspendLayout();
            this.pnlAttachment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tblReportLayout);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(884, 561);
            this.pnlContent.TabIndex = 2;
            // 
            // tblReportLayout
            // 
            this.tblReportLayout.BackColor = System.Drawing.Color.Transparent;
            this.tblReportLayout.ColumnCount = 1;
            this.tblReportLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblReportLayout.Controls.Add(this.pnlReportHeader, 0, 0);
            this.tblReportLayout.Controls.Add(this.lblReportInstructions, 0, 1);
            this.tblReportLayout.Controls.Add(this.tblReportForm, 0, 2);
            this.tblReportLayout.Controls.Add(this.pnlSubmit, 0, 3);
            this.tblReportLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblReportLayout.Location = new System.Drawing.Point(0, 0);
            this.tblReportLayout.Name = "tblReportLayout";
            this.tblReportLayout.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.tblReportLayout.RowCount = 4;
            this.tblReportLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tblReportLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblReportLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblReportLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblReportLayout.Size = new System.Drawing.Size(884, 561);
            this.tblReportLayout.TabIndex = 0;
            // 
            // pnlReportHeader
            // 
            this.pnlReportHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlReportHeader.Controls.Add(this.lblReportSubtitle);
            this.pnlReportHeader.Controls.Add(this.lblReportTitle);
            this.pnlReportHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReportHeader.Location = new System.Drawing.Point(33, 28);
            this.pnlReportHeader.Name = "pnlReportHeader";
            this.pnlReportHeader.Size = new System.Drawing.Size(818, 89);
            this.pnlReportHeader.TabIndex = 0;
            // 
            // lblReportSubtitle
            // 
            this.lblReportSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReportSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.lblReportSubtitle.Location = new System.Drawing.Point(0, 40);
            this.lblReportSubtitle.Name = "lblReportSubtitle";
            this.lblReportSubtitle.Size = new System.Drawing.Size(818, 25);
            this.lblReportSubtitle.TabIndex = 1;
            this.lblReportSubtitle.Text = "Tell us about a problem in your community.";
            this.lblReportSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lblReportTitle.Location = new System.Drawing.Point(0, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(818, 40);
            this.lblReportTitle.TabIndex = 0;
            this.lblReportTitle.Text = "Report an Issue";
            this.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReportInstructions
            // 
            this.lblReportInstructions.AutoSize = true;
            this.lblReportInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportInstructions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblReportInstructions.Location = new System.Drawing.Point(33, 120);
            this.lblReportInstructions.Name = "lblReportInstructions";
            this.lblReportInstructions.Size = new System.Drawing.Size(818, 50);
            this.lblReportInstructions.TabIndex = 1;
            this.lblReportInstructions.Text = "Please provide as much detail as possible so we can assist you.";
            this.lblReportInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblReportForm
            // 
            this.tblReportForm.ColumnCount = 2;
            this.tblReportForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblReportForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblReportForm.Controls.Add(this.lblLocation, 0, 0);
            this.tblReportForm.Controls.Add(this.lblCategory, 0, 1);
            this.tblReportForm.Controls.Add(this.lblDescription, 0, 2);
            this.tblReportForm.Controls.Add(this.lblAttachment, 0, 3);
            this.tblReportForm.Controls.Add(this.txtLocation, 1, 0);
            this.tblReportForm.Controls.Add(this.cmbCategory, 1, 1);
            this.tblReportForm.Controls.Add(this.rtbDescription, 1, 2);
            this.tblReportForm.Controls.Add(this.pnlAttachment, 1, 3);
            this.tblReportForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblReportForm.Location = new System.Drawing.Point(33, 173);
            this.tblReportForm.Name = "tblReportForm";
            this.tblReportForm.RowCount = 4;
            this.tblReportForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblReportForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblReportForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.60606F));
            this.tblReportForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.39394F));
            this.tblReportForm.Size = new System.Drawing.Size(818, 295);
            this.tblReportForm.TabIndex = 2;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lblLocation.Location = new System.Drawing.Point(3, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(94, 55);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(3, 55);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(94, 55);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 110);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(94, 112);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAttachment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachment.Location = new System.Drawing.Point(3, 232);
            this.lblAttachment.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(94, 63);
            this.lblAttachment.TabIndex = 3;
            this.lblAttachment.Text = "Attachment";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(103, 3);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(682, 23);
            this.txtLocation.TabIndex = 4;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(103, 58);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(712, 23);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // rtbDescription
            // 
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(103, 113);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(712, 106);
            this.rtbDescription.TabIndex = 6;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // pnlSubmit
            // 
            this.pnlSubmit.Controls.Add(this.lblProgress);
            this.pnlSubmit.Controls.Add(this.progressReport);
            this.pnlSubmit.Controls.Add(this.btnSubmit);
            this.pnlSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubmit.Location = new System.Drawing.Point(33, 474);
            this.pnlSubmit.Name = "pnlSubmit";
            this.pnlSubmit.Size = new System.Drawing.Size(818, 59);
            this.pnlSubmit.TabIndex = 3;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.lblProgress.Location = new System.Drawing.Point(3, 9);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(166, 13);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "Complete the form to continue";
            // 
            // progressReport
            // 
            this.progressReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressReport.Location = new System.Drawing.Point(6, 25);
            this.progressReport.Maximum = 3;
            this.progressReport.Name = "progressReport";
            this.progressReport.Size = new System.Drawing.Size(220, 8);
            this.progressReport.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressReport.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(665, 9);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 42);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit Issue  →";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlAttachment
            // 
            this.pnlAttachment.Controls.Add(this.lblfile);
            this.pnlAttachment.Controls.Add(this.btnAttach);
            this.pnlAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAttachment.Location = new System.Drawing.Point(103, 225);
            this.pnlAttachment.Name = "pnlAttachment";
            this.pnlAttachment.Size = new System.Drawing.Size(712, 67);
            this.pnlAttachment.TabIndex = 7;
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnAttach.Location = new System.Drawing.Point(0, 0);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(712, 40);
            this.btnAttach.TabIndex = 8;
            this.btnAttach.Text = "Attach Image / Document";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(4, 47);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(82, 13);
            this.lblfile.TabIndex = 9;
            this.lblfile.Text = "No file attached";
            // 
            // ReportIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlContent);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "ReportIssueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report an Issue";
            this.pnlContent.ResumeLayout(false);
            this.tblReportLayout.ResumeLayout(false);
            this.tblReportLayout.PerformLayout();
            this.pnlReportHeader.ResumeLayout(false);
            this.tblReportForm.ResumeLayout(false);
            this.tblReportForm.PerformLayout();
            this.pnlSubmit.ResumeLayout(false);
            this.pnlSubmit.PerformLayout();
            this.pnlAttachment.ResumeLayout(false);
            this.pnlAttachment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TableLayoutPanel tblReportLayout;
        private System.Windows.Forms.Panel pnlReportHeader;
        private System.Windows.Forms.Label lblReportSubtitle;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Label lblReportInstructions;
        private System.Windows.Forms.TableLayoutPanel tblReportForm;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Panel pnlSubmit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ProgressBar progressReport;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Panel pnlAttachment;
        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.Button btnAttach;
    }
}