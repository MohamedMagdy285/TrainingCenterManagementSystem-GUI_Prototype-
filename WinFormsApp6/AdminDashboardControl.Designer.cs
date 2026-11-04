using System.Drawing;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    partial class AdminDashboardControl
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel kpiPanel = null!;

        // KPI Cards
        private Panel cardRevenue = null!, cardRevenueBar = null!;
        private Label lblRevenueTitle = null!, lblRevenueVal = null!;
        private Panel cardAdmins = null!, cardAdminsBar = null!;
        private Label lblAdminsTitle = null!, lblAdminsVal = null!;
        private Panel cardCourses = null!, cardCoursesBar = null!;
        private Label lblCoursesTitle = null!, lblCoursesVal = null!;
        private Panel cardPending = null!, cardPendingBar = null!;
        private Label lblPendingTitle = null!, lblPendingVal = null!;

        private Panel leftPanel = null!;
        private Panel gridHeaderBar = null!;
        private Label lblTableTitle = null!;
        private Button btnOpenAddModal = null!;
        private DataGridView gridAdmins = null!;

        // Designer Grid Columns
        private DataGridViewButtonColumn colView = null!;
        private DataGridViewButtonColumn colUpdate = null!;
        private DataGridViewButtonColumn colDelete = null!;
        private DataGridViewTextBoxColumn colAdminId = null!;
        private DataGridViewTextBoxColumn colFullName = null!;
        private DataGridViewTextBoxColumn colEmail = null!;
        private DataGridViewTextBoxColumn colRole = null!;
        private DataGridViewTextBoxColumn colStatus = null!;

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
            kpiPanel = new TableLayoutPanel();
            cardRevenue = new Panel();
            cardRevenueBar = new Panel();
            lblRevenueTitle = new Label();
            lblRevenueVal = new Label();
            cardAdmins = new Panel();
            cardAdminsBar = new Panel();
            lblAdminsTitle = new Label();
            lblAdminsVal = new Label();
            cardCourses = new Panel();
            cardCoursesBar = new Panel();
            lblCoursesTitle = new Label();
            lblCoursesVal = new Label();
            cardPending = new Panel();
            cardPendingBar = new Panel();
            lblPendingTitle = new Label();
            lblPendingVal = new Label();

            leftPanel = new Panel();
            gridAdmins = new DataGridView();
            gridHeaderBar = new Panel();
            lblTableTitle = new Label();
            btnOpenAddModal = new Button();

            // Designer Columns Setup
            colView = new DataGridViewButtonColumn();
            colUpdate = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            colAdminId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();

            kpiPanel.SuspendLayout();
            cardRevenue.SuspendLayout();
            cardAdmins.SuspendLayout();
            cardCourses.SuspendLayout();
            cardPending.SuspendLayout();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAdmins).BeginInit();
            gridHeaderBar.SuspendLayout();
            SuspendLayout();

            // Control Base Properties
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(leftPanel);
            Controls.Add(kpiPanel);
            Name = "AdminDashboardControl";
            Padding = new Padding(15);
            Size = new Size(1315, 634);

            // kpiPanel
            kpiPanel.ColumnCount = 4;
            kpiPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            kpiPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            kpiPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            kpiPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            kpiPanel.Controls.Add(cardRevenue, 0, 0);
            kpiPanel.Controls.Add(cardAdmins, 1, 0);
            kpiPanel.Controls.Add(cardCourses, 2, 0);
            kpiPanel.Controls.Add(cardPending, 3, 0);
            kpiPanel.Dock = DockStyle.Top;
            kpiPanel.Location = new Point(15, 15);
            kpiPanel.Name = "kpiPanel";
            kpiPanel.Padding = new Padding(0, 0, 0, 15);
            kpiPanel.RowCount = 1;
            kpiPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            kpiPanel.Size = new Size(1285, 100);

            // KPI Cards Configuration
            cardRevenue.BackColor = Color.White;
            cardRevenue.Controls.Add(cardRevenueBar);
            cardRevenue.Controls.Add(lblRevenueTitle);
            cardRevenue.Controls.Add(lblRevenueVal);
            cardRevenue.Dock = DockStyle.Fill;
            cardRevenue.Margin = new Padding(0, 0, 10, 0);
            cardRevenueBar.BackColor = Color.FromArgb(14, 116, 144);
            cardRevenueBar.Dock = DockStyle.Left;
            cardRevenueBar.Size = new Size(5, 85);
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Font = new Font("Segoe UI", 8.5F);
            lblRevenueTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblRevenueTitle.Location = new Point(14, 14);
            lblRevenueTitle.Text = "Total Revenue";
            lblRevenueVal.AutoSize = true;
            lblRevenueVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRevenueVal.ForeColor = Color.FromArgb(30, 41, 59);
            lblRevenueVal.Location = new Point(12, 34);
            lblRevenueVal.Text = "$52,400.00";

            cardAdmins.BackColor = Color.White;
            cardAdmins.Controls.Add(cardAdminsBar);
            cardAdmins.Controls.Add(lblAdminsTitle);
            cardAdmins.Controls.Add(lblAdminsVal);
            cardAdmins.Dock = DockStyle.Fill;
            cardAdmins.Margin = new Padding(0, 0, 10, 0);
            cardAdminsBar.BackColor = Color.FromArgb(6, 182, 212);
            cardAdminsBar.Dock = DockStyle.Left;
            cardAdminsBar.Size = new Size(5, 85);
            lblAdminsTitle.AutoSize = true;
            lblAdminsTitle.Font = new Font("Segoe UI", 8.5F);
            lblAdminsTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblAdminsTitle.Location = new Point(14, 14);
            lblAdminsTitle.Text = "Active System Admins";
            lblAdminsVal.AutoSize = true;
            lblAdminsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAdminsVal.ForeColor = Color.FromArgb(30, 41, 59);
            lblAdminsVal.Location = new Point(12, 34);
            lblAdminsVal.Text = "6";

            cardCourses.BackColor = Color.White;
            cardCourses.Controls.Add(cardCoursesBar);
            cardCourses.Controls.Add(lblCoursesTitle);
            cardCourses.Controls.Add(lblCoursesVal);
            cardCourses.Dock = DockStyle.Fill;
            cardCourses.Margin = new Padding(0, 0, 10, 0);
            cardCoursesBar.BackColor = Color.FromArgb(13, 148, 136);
            cardCoursesBar.Dock = DockStyle.Left;
            cardCoursesBar.Size = new Size(5, 85);
            lblCoursesTitle.AutoSize = true;
            lblCoursesTitle.Font = new Font("Segoe UI", 8.5F);
            lblCoursesTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblCoursesTitle.Location = new Point(14, 14);
            lblCoursesTitle.Text = "Active Courses";
            lblCoursesVal.AutoSize = true;
            lblCoursesVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCoursesVal.ForeColor = Color.FromArgb(30, 41, 59);
            lblCoursesVal.Location = new Point(12, 34);
            lblCoursesVal.Text = "24";

            cardPending.BackColor = Color.White;
            cardPending.Controls.Add(cardPendingBar);
            cardPending.Controls.Add(lblPendingTitle);
            cardPending.Controls.Add(lblPendingVal);
            cardPending.Dock = DockStyle.Fill;
            cardPending.Margin = new Padding(0);
            cardPendingBar.BackColor = Color.FromArgb(0, 90, 112);
            cardPendingBar.Dock = DockStyle.Left;
            cardPendingBar.Size = new Size(5, 85);
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Font = new Font("Segoe UI", 8.5F);
            lblPendingTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblPendingTitle.Location = new Point(14, 14);
            lblPendingTitle.Text = "Pending Approvals";
            lblPendingVal.AutoSize = true;
            lblPendingVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPendingVal.ForeColor = Color.FromArgb(30, 41, 59);
            lblPendingVal.Location = new Point(12, 34);
            lblPendingVal.Text = "14";

            // leftPanel
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(gridAdmins);
            leftPanel.Controls.Add(gridHeaderBar);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(15, 115);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(15);
            leftPanel.Size = new Size(1285, 504);

            // gridHeaderBar
            gridHeaderBar.Controls.Add(lblTableTitle);
            gridHeaderBar.Controls.Add(btnOpenAddModal);
            gridHeaderBar.Dock = DockStyle.Top;
            gridHeaderBar.Height = 45;
            gridHeaderBar.Resize += gridHeaderBar_Resize;

            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTableTitle.Location = new Point(0, 8);
            lblTableTitle.Text = "System Administrators & Permissions";

            btnOpenAddModal.BackColor = Color.FromArgb(14, 116, 144);
            btnOpenAddModal.Cursor = Cursors.Hand;
            btnOpenAddModal.FlatAppearance.BorderSize = 0;
            btnOpenAddModal.FlatStyle = FlatStyle.Flat;
            btnOpenAddModal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOpenAddModal.ForeColor = Color.White;
            btnOpenAddModal.Location = new Point(1105, 4);
            btnOpenAddModal.Size = new Size(160, 34);
            btnOpenAddModal.Text = "➕ Add New Admin";
            btnOpenAddModal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenAddModal.Click += btnOpenAddModal_Click;

            // --- Configure DataGridView Columns for Designer View ---
            colView.HeaderText = "View";
            colView.Name = "colView";
            colView.Text = "👁 View";
            colView.UseColumnTextForButtonValue = true;
            colView.FlatStyle = FlatStyle.Flat;
            colView.Width = 85;

            colUpdate.HeaderText = "Update";
            colUpdate.Name = "colUpdate";
            colUpdate.Text = "✏ Update";
            colUpdate.UseColumnTextForButtonValue = true;
            colUpdate.FlatStyle = FlatStyle.Flat;
            colUpdate.Width = 90;

            colDelete.HeaderText = "Delete";
            colDelete.Name = "colDelete";
            colDelete.Text = "🗑 Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.FlatStyle = FlatStyle.Flat;
            colDelete.Width = 90;

            colAdminId.HeaderText = "Admin ID";
            colAdminId.Name = "colAdminId";
            colAdminId.Width = 110;

            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            colFullName.Width = 180;

            colEmail.HeaderText = "Email Address";
            colEmail.Name = "colEmail";
            colEmail.Width = 220;

            colRole.HeaderText = "Role Permission";
            colRole.Name = "colRole";
            colRole.Width = 150;

            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.Width = 100;

            gridAdmins.BackgroundColor = Color.White;
            gridAdmins.BorderStyle = BorderStyle.None;
            gridAdmins.ColumnHeadersHeight = 35;
            gridAdmins.Dock = DockStyle.Fill;
            gridAdmins.Location = new Point(15, 60);
            gridAdmins.Name = "gridAdmins";
            gridAdmins.RowHeadersVisible = false;
            gridAdmins.RowTemplate.Height = 35;

            // Add Columns to Grid
            gridAdmins.Columns.AddRange(new DataGridViewColumn[] {
                colView, colUpdate, colDelete, colAdminId, colFullName, colEmail, colRole, colStatus
            });

            // Add Designer Sample Rows (لتظهر مباشرة في الشاشة أثناء التعديل)
            gridAdmins.Rows.Add("👁 View", "✏ Update", "🗑 Delete", "ADM-001", "Mohamed Elsisi", "mohamed.admin@academy.com", "Super Admin", "Active");
            gridAdmins.Rows.Add("👁 View", "✏ Update", "🗑 Delete", "ADM-002", "Dr. Alan Turing", "alan.turing@academy.com", "Course Manager", "Active");
            gridAdmins.Rows.Add("👁 View", "✏ Update", "🗑 Delete", "ADM-003", "Sarah Connor", "sarah.c@academy.com", "Financial Officer", "Active");
            gridAdmins.Rows.Add("👁 View", "✏ Update", "🗑 Delete", "ADM-004", "Marcus Aurelius", "marcus.a@academy.com", "Registrar", "Suspended");

            // Layout Assembly
            kpiPanel.ResumeLayout(false);
            cardRevenue.ResumeLayout(false); cardRevenue.PerformLayout();
            cardAdmins.ResumeLayout(false); cardAdmins.PerformLayout();
            cardCourses.ResumeLayout(false); cardCourses.PerformLayout();
            cardPending.ResumeLayout(false); cardPending.PerformLayout();
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridAdmins).EndInit();
            gridHeaderBar.ResumeLayout(false); gridHeaderBar.PerformLayout();
            ResumeLayout(false);
        }
    }
}