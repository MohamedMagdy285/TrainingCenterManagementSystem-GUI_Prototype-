using System.Drawing;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    partial class EntityDetailsModalForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header Elements
        private Panel headerPanel = null!;
        private Label lblBadge = null!;
        private Label lblTitle = null!;

        // Main Layout Container
        private FlowLayoutPanel detailsFlow = null!;

        // KPI Metrics Panel & Cards
        private TableLayoutPanel metricsGrid = null!;
        private Panel pnlMetric1 = null!, pnlMetricBar1 = null!;
        private Label lblMetricKey1 = null!, lblMetricVal1 = null!;
        private Panel pnlMetric2 = null!, pnlMetricBar2 = null!;
        private Label lblMetricKey2 = null!, lblMetricVal2 = null!;
        private Panel pnlMetric3 = null!, pnlMetricBar3 = null!;
        private Label lblMetricKey3 = null!, lblMetricVal3 = null!;

        // Key-Value Rows
        private Panel pnlRow1 = null!, pnlRow2 = null!, pnlRow3 = null!, pnlRow4 = null!;
        private Label lblKey1 = null!, lblVal1 = null!;
        private Label lblKey2 = null!, lblVal2 = null!;
        private Label lblKey3 = null!, lblVal3 = null!;
        private Label lblKey4 = null!, lblVal4 = null!;

        // Description Section
        private Label lblSectionTitle = null!;
        private TextBox txtSectionText = null!;

        // Video Section
        private Label lblVideoSectionHeader = null!;
        private Panel pnlVideoCard = null!;
        private Label lblPlayIcon = null!;
        private Label lblVidTitle = null!;
        private Label lblVidSub = null!;
        private Button btnPlay = null!;

        // Footer Elements
        private Panel footerPanel = null!;
        private Button btnClose = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new Panel();
            this.lblBadge = new Label();
            this.lblTitle = new Label();

            this.detailsFlow = new FlowLayoutPanel();

            // KPI Grid
            this.metricsGrid = new TableLayoutPanel();
            this.pnlMetric1 = new Panel();
            this.pnlMetricBar1 = new Panel();
            this.lblMetricKey1 = new Label();
            this.lblMetricVal1 = new Label();

            this.pnlMetric2 = new Panel();
            this.pnlMetricBar2 = new Panel();
            this.lblMetricKey2 = new Label();
            this.lblMetricVal2 = new Label();

            this.pnlMetric3 = new Panel();
            this.pnlMetricBar3 = new Panel();
            this.lblMetricKey3 = new Label();
            this.lblMetricVal3 = new Label();

            // Rows
            this.pnlRow1 = new Panel();
            this.lblKey1 = new Label();
            this.lblVal1 = new Label();

            this.pnlRow2 = new Panel();
            this.lblKey2 = new Label();
            this.lblVal2 = new Label();

            this.pnlRow3 = new Panel();
            this.lblKey3 = new Label();
            this.lblVal3 = new Label();

            this.pnlRow4 = new Panel();
            this.lblKey4 = new Label();
            this.lblVal4 = new Label();

            // Description
            this.lblSectionTitle = new Label();
            this.txtSectionText = new TextBox();

            // Video Card
            this.lblVideoSectionHeader = new Label();
            this.pnlVideoCard = new Panel();
            this.lblPlayIcon = new Label();
            this.lblVidTitle = new Label();
            this.lblVidSub = new Label();
            this.btnPlay = new Button();

            // Footer
            this.footerPanel = new Panel();
            this.btnClose = new Button();

            this.headerPanel.SuspendLayout();
            this.detailsFlow.SuspendLayout();
            this.metricsGrid.SuspendLayout();
            this.pnlMetric1.SuspendLayout();
            this.pnlMetric2.SuspendLayout();
            this.pnlMetric3.SuspendLayout();
            this.pnlRow1.SuspendLayout();
            this.pnlRow2.SuspendLayout();
            this.pnlRow3.SuspendLayout();
            this.pnlRow4.SuspendLayout();
            this.pnlVideoCard.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();

            // Form Properties
            this.Text = "Entity Details Modal";
            this.Size = new Size(520, 630);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Padding = new Padding(20);

            // --- Header Panel ---
            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Height = 70;
            this.headerPanel.BackColor = Color.FromArgb(15, 23, 42);
            this.headerPanel.Padding = new Padding(15);

            this.lblBadge.Text = "CRS-101";
            this.lblBadge.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.lblBadge.ForeColor = Color.White;
            this.lblBadge.BackColor = Color.FromArgb(14, 116, 144);
            this.lblBadge.Padding = new Padding(6, 2, 6, 2);
            this.lblBadge.AutoSize = true;
            this.lblBadge.Location = new Point(15, 12);

            this.lblTitle.Text = "C# .NET Core Masterclass";
            this.lblTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(12, 36);

            this.headerPanel.Controls.Add(this.lblBadge);
            this.headerPanel.Controls.Add(this.lblTitle);

            // --- Details Flow Layout Container ---
            this.detailsFlow.Dock = DockStyle.Fill;
            this.detailsFlow.FlowDirection = FlowDirection.TopDown;
            this.detailsFlow.WrapContents = false;
            this.detailsFlow.AutoScroll = true;
            this.detailsFlow.Padding = new Padding(10, 15, 10, 10);
            this.detailsFlow.BackColor = Color.Transparent;

            // --- KPI Metrics Grid ---
            this.metricsGrid.Size = new Size(450, 65);
            this.metricsGrid.ColumnCount = 3;
            this.metricsGrid.RowCount = 1;
            this.metricsGrid.Margin = new Padding(0, 0, 0, 15);
            this.metricsGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.metricsGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.metricsGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));

            // Metric Card 1
            this.pnlMetric1.Dock = DockStyle.Fill;
            this.pnlMetric1.BackColor = Color.White;
            this.pnlMetric1.Margin = new Padding(3);
            this.pnlMetricBar1.Dock = DockStyle.Top;
            this.pnlMetricBar1.Height = 3;
            this.pnlMetricBar1.BackColor = Color.FromArgb(13, 148, 136);
            this.lblMetricKey1.Text = "Category";
            this.lblMetricKey1.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblMetricKey1.Font = new Font("Segoe UI", 7.5F);
            this.lblMetricKey1.Location = new Point(6, 8);
            this.lblMetricKey1.AutoSize = true;
            this.lblMetricVal1.Text = "Backend";
            this.lblMetricVal1.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblMetricVal1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.lblMetricVal1.Location = new Point(6, 24);
            this.lblMetricVal1.AutoSize = true;
            this.pnlMetric1.Controls.AddRange(new Control[] { this.pnlMetricBar1, this.lblMetricKey1, this.lblMetricVal1 });

            // Metric Card 2
            this.pnlMetric2.Dock = DockStyle.Fill;
            this.pnlMetric2.BackColor = Color.White;
            this.pnlMetric2.Margin = new Padding(3);
            this.pnlMetricBar2.Dock = DockStyle.Top;
            this.pnlMetricBar2.Height = 3;
            this.pnlMetricBar2.BackColor = Color.FromArgb(6, 182, 212);
            this.lblMetricKey2.Text = "Duration";
            this.lblMetricKey2.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblMetricKey2.Font = new Font("Segoe UI", 7.5F);
            this.lblMetricKey2.Location = new Point(6, 8);
            this.lblMetricKey2.AutoSize = true;
            this.lblMetricVal2.Text = "45 Hours";
            this.lblMetricVal2.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblMetricVal2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.lblMetricVal2.Location = new Point(6, 24);
            this.lblMetricVal2.AutoSize = true;
            this.pnlMetric2.Controls.AddRange(new Control[] { this.pnlMetricBar2, this.lblMetricKey2, this.lblMetricVal2 });

            // Metric Card 3
            this.pnlMetric3.Dock = DockStyle.Fill;
            this.pnlMetric3.BackColor = Color.White;
            this.pnlMetric3.Margin = new Padding(3);
            this.pnlMetricBar3.Dock = DockStyle.Top;
            this.pnlMetricBar3.Height = 3;
            this.pnlMetricBar3.BackColor = Color.FromArgb(14, 116, 144);
            this.lblMetricKey3.Text = "Fee";
            this.lblMetricKey3.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblMetricKey3.Font = new Font("Segoe UI", 7.5F);
            this.lblMetricKey3.Location = new Point(6, 8);
            this.lblMetricKey3.AutoSize = true;
            this.lblMetricVal3.Text = "$299.00";
            this.lblMetricVal3.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblMetricVal3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.lblMetricVal3.Location = new Point(6, 24);
            this.lblMetricVal3.AutoSize = true;
            this.pnlMetric3.Controls.AddRange(new Control[] { this.pnlMetricBar3, this.lblMetricKey3, this.lblMetricVal3 });

            this.metricsGrid.Controls.Add(this.pnlMetric1, 0, 0);
            this.metricsGrid.Controls.Add(this.pnlMetric2, 1, 0);
            this.metricsGrid.Controls.Add(this.pnlMetric3, 2, 0);

            // --- Key-Value Rows ---
            // Row 1
            this.pnlRow1.Size = new Size(450, 28);
            this.pnlRow1.Margin = new Padding(0, 2, 0, 2);
            this.lblKey1.Text = "Assigned Instructor:";
            this.lblKey1.Font = new Font("Segoe UI Semibold", 8.75F, FontStyle.Bold);
            this.lblKey1.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblKey1.Location = new Point(0, 4);
            this.lblKey1.Width = 150;
            this.lblVal1.Text = "Dr. Alan Turing";
            this.lblVal1.Font = new Font("Segoe UI", 9F);
            this.lblVal1.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblVal1.Location = new Point(155, 4);
            this.lblVal1.Width = 290;
            this.pnlRow1.Controls.AddRange(new Control[] { this.lblKey1, this.lblVal1 });

            // Row 2
            this.pnlRow2.Size = new Size(450, 28);
            this.pnlRow2.Margin = new Padding(0, 2, 0, 2);
            this.lblKey2.Text = "Schedule:";
            this.lblKey2.Font = new Font("Segoe UI Semibold", 8.75F, FontStyle.Bold);
            this.lblKey2.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblKey2.Location = new Point(0, 4);
            this.lblKey2.Width = 150;
            this.lblVal2.Text = "Tues & Thurs (6-9 PM)";
            this.lblVal2.Font = new Font("Segoe UI", 9F);
            this.lblVal2.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblVal2.Location = new Point(155, 4);
            this.lblVal2.Width = 290;
            this.pnlRow2.Controls.AddRange(new Control[] { this.lblKey2, this.lblVal2 });

            // Row 3
            this.pnlRow3.Size = new Size(450, 28);
            this.pnlRow3.Margin = new Padding(0, 2, 0, 2);
            this.lblKey3.Text = "Room Allocation:";
            this.lblKey3.Font = new Font("Segoe UI Semibold", 8.75F, FontStyle.Bold);
            this.lblKey3.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblKey3.Location = new Point(0, 4);
            this.lblKey3.Width = 150;
            this.lblVal3.Text = "Lab 4 - Science Building";
            this.lblVal3.Font = new Font("Segoe UI", 9F);
            this.lblVal3.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblVal3.Location = new Point(155, 4);
            this.lblVal3.Width = 290;
            this.pnlRow3.Controls.AddRange(new Control[] { this.lblKey3, this.lblVal3 });

            // Row 4
            this.pnlRow4.Size = new Size(450, 28);
            this.pnlRow4.Margin = new Padding(0, 2, 0, 2);
            this.lblKey4.Text = "Status:";
            this.lblKey4.Font = new Font("Segoe UI Semibold", 8.75F, FontStyle.Bold);
            this.lblKey4.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblKey4.Location = new Point(0, 4);
            this.lblKey4.Width = 150;
            this.lblVal4.Text = "Active Enrollment";
            this.lblVal4.Font = new Font("Segoe UI", 9F);
            this.lblVal4.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblVal4.Location = new Point(155, 4);
            this.lblVal4.Width = 290;
            this.pnlRow4.Controls.AddRange(new Control[] { this.lblKey4, this.lblVal4 });

            // --- Description Section ---
            this.lblSectionTitle.Text = "Course Description:";
            this.lblSectionTitle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            this.lblSectionTitle.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblSectionTitle.Margin = new Padding(0, 10, 0, 4);
            this.lblSectionTitle.AutoSize = true;

            this.txtSectionText.Text = "Comprehensive training covering C# .NET Core architecture, entity framework, and web API integration.";
            this.txtSectionText.Size = new Size(450, 55);
            this.txtSectionText.Multiline = true;
            this.txtSectionText.ReadOnly = true;
            this.txtSectionText.BackColor = Color.White;
            this.txtSectionText.ForeColor = Color.FromArgb(30, 41, 59);
            this.txtSectionText.Font = new Font("Segoe UI", 9F);
            this.txtSectionText.BorderStyle = BorderStyle.FixedSingle;

            // --- Video Section ---
            this.lblVideoSectionHeader.Text = "Course Intro Video:";
            this.lblVideoSectionHeader.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            this.lblVideoSectionHeader.ForeColor = Color.FromArgb(30, 41, 59);
            this.lblVideoSectionHeader.Margin = new Padding(0, 12, 0, 4);
            this.lblVideoSectionHeader.AutoSize = true;

            this.pnlVideoCard.Size = new Size(450, 75);
            this.pnlVideoCard.BackColor = Color.FromArgb(15, 23, 42);
            this.pnlVideoCard.Margin = new Padding(0, 2, 0, 10);

            this.lblPlayIcon.Text = "▶";
            this.lblPlayIcon.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblPlayIcon.ForeColor = Color.FromArgb(6, 182, 212);
            this.lblPlayIcon.Location = new Point(14, 18);
            this.lblPlayIcon.AutoSize = true;

            this.lblVidTitle.Text = "C# .NET Core - Syllabus Preview";
            this.lblVidTitle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            this.lblVidTitle.ForeColor = Color.White;
            this.lblVidTitle.Location = new Point(55, 16);
            this.lblVidTitle.AutoSize = true;

            this.lblVidSub.Text = "Duration: 03:45 • Full Course Preview";
            this.lblVidSub.Font = new Font("Segoe UI", 8.5F);
            this.lblVidSub.ForeColor = Color.FromArgb(180, 205, 225);
            this.lblVidSub.Location = new Point(55, 38);
            this.lblVidSub.AutoSize = true;

            this.btnPlay.Text = "▶ Play Video";
            this.btnPlay.BackColor = Color.FromArgb(14, 116, 144);
            this.btnPlay.ForeColor = Color.White;
            this.btnPlay.FlatStyle = FlatStyle.Flat;
            this.btnPlay.Size = new Size(95, 30);
            this.btnPlay.Location = new Point(340, 22);
            this.btnPlay.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            this.btnPlay.Cursor = Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;

            this.pnlVideoCard.Controls.AddRange(new Control[] { this.lblPlayIcon, this.lblVidTitle, this.lblVidSub, this.btnPlay });

            // Assembly Flow Container
            this.detailsFlow.Controls.Add(this.metricsGrid);
            this.detailsFlow.Controls.Add(this.pnlRow1);
            this.detailsFlow.Controls.Add(this.pnlRow2);
            this.detailsFlow.Controls.Add(this.pnlRow3);
            this.detailsFlow.Controls.Add(this.pnlRow4);
            this.detailsFlow.Controls.Add(this.lblSectionTitle);
            this.detailsFlow.Controls.Add(this.txtSectionText);
            this.detailsFlow.Controls.Add(this.lblVideoSectionHeader);
            this.detailsFlow.Controls.Add(this.pnlVideoCard);

            // --- Footer Panel ---
            this.footerPanel.Dock = DockStyle.Bottom;
            this.footerPanel.Height = 50;
            this.footerPanel.BackColor = Color.Transparent;

            this.btnClose.Text = "Close Window";
            this.btnClose.BackColor = Color.FromArgb(0, 90, 112);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Size = new Size(120, 36);
            this.btnClose.Location = new Point(335, 10);
            this.btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            this.btnClose.DialogResult = DialogResult.OK;
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;

            this.footerPanel.Controls.Add(this.btnClose);

            // Assembly Main Form
            this.Controls.Add(this.detailsFlow);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerPanel);

            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.detailsFlow.ResumeLayout(false);
            this.detailsFlow.PerformLayout();
            this.metricsGrid.ResumeLayout(false);
            this.pnlMetric1.ResumeLayout(false);
            this.pnlMetric1.PerformLayout();
            this.pnlMetric2.ResumeLayout(false);
            this.pnlMetric2.PerformLayout();
            this.pnlMetric3.ResumeLayout(false);
            this.pnlMetric3.PerformLayout();
            this.pnlRow1.ResumeLayout(false);
            this.pnlRow2.ResumeLayout(false);
            this.pnlRow3.ResumeLayout(false);
            this.pnlRow4.ResumeLayout(false);
            this.pnlVideoCard.ResumeLayout(false);
            this.pnlVideoCard.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}