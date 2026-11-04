using System.Drawing;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel sidebarPanel = null!;
        private Label lblBrand = null!;
        private Panel headerPanel = null!;
        private Label lblHeaderTitle = null!;
        private Panel contentPanel = null!;
        private TabControl mainTabControl = null!;

        private Button btnDashboard = null!;
        private Button btnCourses = null!;
        private Button btnInstructors = null!;
        private Button btnMembers = null!;
        private Button btnApplications = null!;
        private Button btnProfile = null!;

        private TabPage tabDashboard = null!;
        private TabPage tabCourses = null!;
        private TabPage tabInstructors = null!;
        private TabPage tabMembers = null!;
        private TabPage tabApplications = null!;
        private TabPage tabProfile = null!;

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
            this.sidebarPanel = new Panel();
            this.lblBrand = new Label();
            this.headerPanel = new Panel();
            this.lblHeaderTitle = new Label();
            this.contentPanel = new Panel();
            this.mainTabControl = new TabControl();

            this.btnDashboard = new Button();
            this.btnCourses = new Button();
            this.btnInstructors = new Button();
            this.btnMembers = new Button();
            this.btnApplications = new Button();
            this.btnProfile = new Button();

            this.tabDashboard = new TabPage();
            this.tabCourses = new TabPage();
            this.tabInstructors = new TabPage();
            this.tabMembers = new TabPage();
            this.tabApplications = new TabPage();
            this.tabProfile = new TabPage();

            this.sidebarPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();

            // Form Properties
            this.Text = "Training Center Management System";
            this.Size = new Size(1300, 820);
            this.MinimumSize = new Size(1100, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);

            // sidebarPanel
            this.sidebarPanel.Dock = DockStyle.Left;
            this.sidebarPanel.Width = 240;
            this.sidebarPanel.BackColor = Color.FromArgb(15, 23, 42);

            // lblBrand
            this.lblBrand.Text = "ACADEMY HUB";
            this.lblBrand.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lblBrand.ForeColor = Color.White;
            this.lblBrand.Dock = DockStyle.Top;
            this.lblBrand.Height = 65;
            this.lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            this.lblBrand.BackColor = Color.FromArgb(0, 2, 50);

            // headerPanel
            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Height = 65;
            this.headerPanel.BackColor = Color.FromArgb(0, 90, 112);

            // lblHeaderTitle
            this.lblHeaderTitle.Text = "Admin Control Center";
            this.lblHeaderTitle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = Color.White;
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Location = new Point(22, 18);

            // btnDashboard
            this.btnDashboard.Text = "  📊  Admin Dashboard";
            this.btnDashboard.Location = new Point(0, 80);
            this.btnDashboard.Size = new Size(240, 48);
            this.btnDashboard.FlatStyle = FlatStyle.Flat;
            this.btnDashboard.ForeColor = Color.FromArgb(190, 205, 220);
            this.btnDashboard.BackColor = Color.FromArgb(15, 23, 42);
            this.btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            this.btnDashboard.Font = new Font("Segoe UI", 10F);
            this.btnDashboard.Cursor = Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            // btnCourses
            this.btnCourses.Text = "  📘  Courses";
            this.btnCourses.Location = new Point(0, 135);
            this.btnCourses.Size = new Size(240, 48);
            this.btnCourses.FlatStyle = FlatStyle.Flat;
            this.btnCourses.ForeColor = Color.FromArgb(190, 205, 220);
            this.btnCourses.BackColor = Color.FromArgb(15, 23, 42);
            this.btnCourses.TextAlign = ContentAlignment.MiddleLeft;
            this.btnCourses.Font = new Font("Segoe UI", 10F);
            this.btnCourses.Cursor = Cursors.Hand;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);

            // btnInstructors
            this.btnInstructors.Text = "  👨‍🏫  Instructors";
            this.btnInstructors.Location = new Point(0, 190);
            this.btnInstructors.Size = new Size(240, 48);
            this.btnInstructors.FlatStyle = FlatStyle.Flat;
            this.btnInstructors.ForeColor = Color.FromArgb(190, 205, 220);
            this.btnInstructors.BackColor = Color.FromArgb(15, 23, 42);
            this.btnInstructors.TextAlign = ContentAlignment.MiddleLeft;
            this.btnInstructors.Font = new Font("Segoe UI", 10F);
            this.btnInstructors.Cursor = Cursors.Hand;
            this.btnInstructors.FlatAppearance.BorderSize = 0;
            this.btnInstructors.Click += new System.EventHandler(this.btnInstructors_Click);

            // btnMembers
            this.btnMembers.Text = "  👥  Members & Trainees";
            this.btnMembers.Location = new Point(0, 245);
            this.btnMembers.Size = new Size(240, 48);
            this.btnMembers.FlatStyle = FlatStyle.Flat;
            this.btnMembers.ForeColor = Color.FromArgb(190, 205, 220);
            this.btnMembers.BackColor = Color.FromArgb(15, 23, 42);
            this.btnMembers.TextAlign = ContentAlignment.MiddleLeft;
            this.btnMembers.Font = new Font("Segoe UI", 10F);
            this.btnMembers.Cursor = Cursors.Hand;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);

            // btnApplications
            this.btnApplications.Text = "  📝  Applications";
            this.btnApplications.Location = new Point(0, 300);
            this.btnApplications.Size = new Size(240, 48);
            this.btnApplications.FlatStyle = FlatStyle.Flat;
            this.btnApplications.ForeColor = Color.FromArgb(190, 205, 220);
            this.btnApplications.BackColor = Color.FromArgb(15, 23, 42);
            this.btnApplications.TextAlign = ContentAlignment.MiddleLeft;
            this.btnApplications.Font = new Font("Segoe UI", 10F);
            this.btnApplications.Cursor = Cursors.Hand;
            this.btnApplications.FlatAppearance.BorderSize = 0;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);

            // btnProfile
            this.btnProfile.Text = "  👤  My Profile";
            this.btnProfile.Location = new Point(0, 355);
            this.btnProfile.Size = new Size(240, 48);
            this.btnProfile.FlatStyle = FlatStyle.Flat;
            this.btnProfile.ForeColor = Color.FromArgb(190, 205, 220);
            this.btnProfile.BackColor = Color.FromArgb(15, 23, 42);
            this.btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            this.btnProfile.Font = new Font("Segoe UI", 10F);
            this.btnProfile.Cursor = Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);

            // Assembly Sidebar
            this.sidebarPanel.Controls.Add(this.lblBrand);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.Controls.Add(this.btnCourses);
            this.sidebarPanel.Controls.Add(this.btnInstructors);
            this.sidebarPanel.Controls.Add(this.btnMembers);
            this.sidebarPanel.Controls.Add(this.btnApplications);
            this.sidebarPanel.Controls.Add(this.btnProfile);

            this.headerPanel.Controls.Add(this.lblHeaderTitle);

            // contentPanel
            this.contentPanel.Dock = DockStyle.Fill;
            this.contentPanel.Padding = new Padding(15);
            this.contentPanel.BackColor = Color.FromArgb(245, 247, 250);

            // mainTabControl
            this.mainTabControl.Dock = DockStyle.Fill;
            this.mainTabControl.Appearance = TabAppearance.FlatButtons;
            this.mainTabControl.ItemSize = new Size(0, 1);
            this.mainTabControl.SizeMode = TabSizeMode.Fixed;

            // TabPages
            this.tabDashboard.Text = "Dashboard";
            this.tabCourses.Text = "Courses";
            this.tabInstructors.Text = "Instructors";
            this.tabMembers.Text = "Members";
            this.tabApplications.Text = "Applications";
            this.tabProfile.Text = "Profile";

            this.tabDashboard.BackColor = Color.FromArgb(245, 247, 250);
            this.tabCourses.BackColor = Color.FromArgb(245, 247, 250);
            this.tabInstructors.BackColor = Color.FromArgb(245, 247, 250);
            this.tabMembers.BackColor = Color.FromArgb(245, 247, 250);
            this.tabApplications.BackColor = Color.FromArgb(245, 247, 250);
            this.tabProfile.BackColor = Color.FromArgb(245, 247, 250);

            this.mainTabControl.TabPages.Add(this.tabDashboard);
            this.mainTabControl.TabPages.Add(this.tabCourses);
            this.mainTabControl.TabPages.Add(this.tabInstructors);
            this.mainTabControl.TabPages.Add(this.tabMembers);
            this.mainTabControl.TabPages.Add(this.tabApplications);
            this.mainTabControl.TabPages.Add(this.tabProfile);

            this.contentPanel.Controls.Add(this.mainTabControl);

            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidebarPanel);

            this.sidebarPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}