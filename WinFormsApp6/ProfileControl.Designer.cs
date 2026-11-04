using System.Drawing;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    partial class ProfileControl
    {
        private System.ComponentModel.IContainer components = null;

        private Panel cardPanel = null!;
        private Panel headerPanel = null!;
        private Label lblAvatar = null!;
        private Label lblName = null!;
        private Label lblRole = null!;

        private FlowLayoutPanel flowPanel = null!;

        private Label lblSecPersonal = null!;
        private Panel pnlFullName = null!;
        private Label lblFullNameKey = null!;
        private TextBox txtFullNameVal = null!;

        private Panel pnlEmail = null!;
        private Label lblEmailKey = null!;
        private TextBox txtEmailVal = null!;

        private Panel pnlPhone = null!;
        private Label lblPhoneKey = null!;
        private TextBox txtPhoneVal = null!;

        private Label lblSecSecurity = null!;
        private Panel pnlSystemRole = null!;
        private Label lblSystemRoleKey = null!;
        private TextBox txtSystemRoleVal = null!;

        private Panel pnlAccountStatus = null!;
        private Label lblAccountStatusKey = null!;
        private TextBox txtAccountStatusVal = null!;

        private Panel pnlLastLogin = null!;
        private Label lblLastLoginKey = null!;
        private TextBox txtLastLoginVal = null!;

        private Panel actionsPanel = null!;
        private Button btnChangePassword = null!;

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
            cardPanel = new Panel();
            flowPanel = new FlowLayoutPanel();
            lblSecPersonal = new Label();
            pnlFullName = new Panel();
            lblFullNameKey = new Label();
            txtFullNameVal = new TextBox();
            pnlEmail = new Panel();
            lblEmailKey = new Label();
            txtEmailVal = new TextBox();
            pnlPhone = new Panel();
            lblPhoneKey = new Label();
            txtPhoneVal = new TextBox();
            lblSecSecurity = new Label();
            pnlSystemRole = new Panel();
            lblSystemRoleKey = new Label();
            txtSystemRoleVal = new TextBox();
            pnlAccountStatus = new Panel();
            lblAccountStatusKey = new Label();
            txtAccountStatusVal = new TextBox();
            pnlLastLogin = new Panel();
            lblLastLoginKey = new Label();
            txtLastLoginVal = new TextBox();
            actionsPanel = new Panel();
            btnChangePassword = new Button();
            headerPanel = new Panel();
            lblAvatar = new Label();
            lblName = new Label();
            lblRole = new Label();
            cardPanel.SuspendLayout();
            flowPanel.SuspendLayout();
            pnlFullName.SuspendLayout();
            pnlEmail.SuspendLayout();
            pnlPhone.SuspendLayout();
            pnlSystemRole.SuspendLayout();
            pnlAccountStatus.SuspendLayout();
            pnlLastLogin.SuspendLayout();
            actionsPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.White;
            cardPanel.Controls.Add(flowPanel);
            cardPanel.Controls.Add(actionsPanel);
            cardPanel.Controls.Add(headerPanel);
            cardPanel.Dock = DockStyle.Fill;
            cardPanel.Location = new Point(20, 20);
            cardPanel.Name = "cardPanel";
            cardPanel.Padding = new Padding(25);
            cardPanel.Size = new Size(1275, 594);
            cardPanel.TabIndex = 0;
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.Transparent;
            flowPanel.Controls.Add(lblSecPersonal);
            flowPanel.Controls.Add(pnlFullName);
            flowPanel.Controls.Add(pnlEmail);
            flowPanel.Controls.Add(pnlPhone);
            flowPanel.Controls.Add(lblSecSecurity);
            flowPanel.Controls.Add(pnlSystemRole);
            flowPanel.Controls.Add(pnlAccountStatus);
            flowPanel.Controls.Add(pnlLastLogin);
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(25, 115);
            flowPanel.Name = "flowPanel";
            flowPanel.Padding = new Padding(10, 20, 10, 10);
            flowPanel.Size = new Size(1225, 404);
            flowPanel.TabIndex = 0;
            flowPanel.WrapContents = false;
            // 
            // lblSecPersonal
            // 
            lblSecPersonal.AutoSize = true;
            lblSecPersonal.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblSecPersonal.ForeColor = Color.FromArgb(14, 116, 144);
            lblSecPersonal.Location = new Point(10, 35);
            lblSecPersonal.Margin = new Padding(0, 15, 0, 8);
            lblSecPersonal.Name = "lblSecPersonal";
            lblSecPersonal.Size = new Size(192, 25);
            lblSecPersonal.TabIndex = 0;
            lblSecPersonal.Text = "Personal Information";
            // 
            // pnlFullName
            // 
            pnlFullName.Controls.Add(lblFullNameKey);
            pnlFullName.Controls.Add(txtFullNameVal);
            pnlFullName.Location = new Point(10, 70);
            pnlFullName.Margin = new Padding(0, 2, 0, 2);
            pnlFullName.Name = "pnlFullName";
            pnlFullName.Size = new Size(500, 32);
            pnlFullName.TabIndex = 1;
            // 
            // lblFullNameKey
            // 
            lblFullNameKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblFullNameKey.ForeColor = Color.FromArgb(100, 116, 139);
            lblFullNameKey.Location = new Point(0, 6);
            lblFullNameKey.Name = "lblFullNameKey";
            lblFullNameKey.Size = new Size(160, 20);
            lblFullNameKey.TabIndex = 0;
            lblFullNameKey.Text = "Full Name:";
            // 
            // txtFullNameVal
            // 
            txtFullNameVal.BackColor = Color.FromArgb(245, 247, 250);
            txtFullNameVal.BorderStyle = BorderStyle.FixedSingle;
            txtFullNameVal.Font = new Font("Segoe UI", 9.5F);
            txtFullNameVal.ForeColor = Color.FromArgb(30, 41, 59);
            txtFullNameVal.Location = new Point(165, 4);
            txtFullNameVal.Name = "txtFullNameVal";
            txtFullNameVal.ReadOnly = true;
            txtFullNameVal.Size = new Size(320, 29);
            txtFullNameVal.TabIndex = 1;
            txtFullNameVal.Text = "Mohamed Magdy Abdelmoniem Elsisi";
            // 
            // pnlEmail
            // 
            pnlEmail.Controls.Add(lblEmailKey);
            pnlEmail.Controls.Add(txtEmailVal);
            pnlEmail.Location = new Point(10, 106);
            pnlEmail.Margin = new Padding(0, 2, 0, 2);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(500, 32);
            pnlEmail.TabIndex = 2;
            // 
            // lblEmailKey
            // 
            lblEmailKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmailKey.ForeColor = Color.FromArgb(100, 116, 139);
            lblEmailKey.Location = new Point(0, 6);
            lblEmailKey.Name = "lblEmailKey";
            lblEmailKey.Size = new Size(160, 20);
            lblEmailKey.TabIndex = 0;
            lblEmailKey.Text = "Email Address:";
            // 
            // txtEmailVal
            // 
            txtEmailVal.BackColor = Color.FromArgb(245, 247, 250);
            txtEmailVal.BorderStyle = BorderStyle.FixedSingle;
            txtEmailVal.Font = new Font("Segoe UI", 9.5F);
            txtEmailVal.ForeColor = Color.FromArgb(30, 41, 59);
            txtEmailVal.Location = new Point(165, 4);
            txtEmailVal.Name = "txtEmailVal";
            txtEmailVal.ReadOnly = true;
            txtEmailVal.Size = new Size(320, 29);
            txtEmailVal.TabIndex = 1;
            txtEmailVal.Text = "mohamed.elsisi@academy.com";
            // 
            // pnlPhone
            // 
            pnlPhone.Controls.Add(lblPhoneKey);
            pnlPhone.Controls.Add(txtPhoneVal);
            pnlPhone.Location = new Point(10, 142);
            pnlPhone.Margin = new Padding(0, 2, 0, 2);
            pnlPhone.Name = "pnlPhone";
            pnlPhone.Size = new Size(500, 32);
            pnlPhone.TabIndex = 3;
            // 
            // lblPhoneKey
            // 
            lblPhoneKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPhoneKey.ForeColor = Color.FromArgb(100, 116, 139);
            lblPhoneKey.Location = new Point(0, 6);
            lblPhoneKey.Name = "lblPhoneKey";
            lblPhoneKey.Size = new Size(160, 20);
            lblPhoneKey.TabIndex = 0;
            lblPhoneKey.Text = "Phone Number:";
            // 
            // txtPhoneVal
            // 
            txtPhoneVal.BackColor = Color.FromArgb(245, 247, 250);
            txtPhoneVal.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneVal.Font = new Font("Segoe UI", 9.5F);
            txtPhoneVal.ForeColor = Color.FromArgb(30, 41, 59);
            txtPhoneVal.Location = new Point(165, 4);
            txtPhoneVal.Name = "txtPhoneVal";
            txtPhoneVal.ReadOnly = true;
            txtPhoneVal.Size = new Size(320, 29);
            txtPhoneVal.TabIndex = 1;
            txtPhoneVal.Text = "+20 101 234 5678";
            // 
            // lblSecSecurity
            // 
            lblSecSecurity.AutoSize = true;
            lblSecSecurity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblSecSecurity.ForeColor = Color.FromArgb(14, 116, 144);
            lblSecSecurity.Location = new Point(10, 191);
            lblSecSecurity.Margin = new Padding(0, 15, 0, 8);
            lblSecSecurity.Name = "lblSecSecurity";
            lblSecSecurity.Size = new Size(263, 25);
            lblSecSecurity.TabIndex = 4;
            lblSecSecurity.Text = "Account Security & Credentials";
            // 
            // pnlSystemRole
            // 
            pnlSystemRole.Controls.Add(lblSystemRoleKey);
            pnlSystemRole.Controls.Add(txtSystemRoleVal);
            pnlSystemRole.Location = new Point(10, 226);
            pnlSystemRole.Margin = new Padding(0, 2, 0, 2);
            pnlSystemRole.Name = "pnlSystemRole";
            pnlSystemRole.Size = new Size(500, 32);
            pnlSystemRole.TabIndex = 5;
            // 
            // lblSystemRoleKey
            // 
            lblSystemRoleKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSystemRoleKey.ForeColor = Color.FromArgb(100, 116, 139);
            lblSystemRoleKey.Location = new Point(0, 6);
            lblSystemRoleKey.Name = "lblSystemRoleKey";
            lblSystemRoleKey.Size = new Size(160, 20);
            lblSystemRoleKey.TabIndex = 0;
            lblSystemRoleKey.Text = "System Role:";
            // 
            // txtSystemRoleVal
            // 
            txtSystemRoleVal.BackColor = Color.FromArgb(245, 247, 250);
            txtSystemRoleVal.BorderStyle = BorderStyle.FixedSingle;
            txtSystemRoleVal.Font = new Font("Segoe UI", 9.5F);
            txtSystemRoleVal.ForeColor = Color.FromArgb(30, 41, 59);
            txtSystemRoleVal.Location = new Point(165, 4);
            txtSystemRoleVal.Name = "txtSystemRoleVal";
            txtSystemRoleVal.ReadOnly = true;
            txtSystemRoleVal.Size = new Size(320, 29);
            txtSystemRoleVal.TabIndex = 1;
            txtSystemRoleVal.Text = "Super Administrator";
            // 
            // pnlAccountStatus
            // 
            pnlAccountStatus.Controls.Add(lblAccountStatusKey);
            pnlAccountStatus.Controls.Add(txtAccountStatusVal);
            pnlAccountStatus.Location = new Point(10, 262);
            pnlAccountStatus.Margin = new Padding(0, 2, 0, 2);
            pnlAccountStatus.Name = "pnlAccountStatus";
            pnlAccountStatus.Size = new Size(500, 32);
            pnlAccountStatus.TabIndex = 6;
            // 
            // lblAccountStatusKey
            // 
            lblAccountStatusKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAccountStatusKey.ForeColor = Color.FromArgb(100, 116, 139);
            lblAccountStatusKey.Location = new Point(0, 6);
            lblAccountStatusKey.Name = "lblAccountStatusKey";
            lblAccountStatusKey.Size = new Size(160, 20);
            lblAccountStatusKey.TabIndex = 0;
            lblAccountStatusKey.Text = "Account Status:";
            // 
            // txtAccountStatusVal
            // 
            txtAccountStatusVal.BackColor = Color.FromArgb(245, 247, 250);
            txtAccountStatusVal.BorderStyle = BorderStyle.FixedSingle;
            txtAccountStatusVal.Font = new Font("Segoe UI", 9.5F);
            txtAccountStatusVal.ForeColor = Color.FromArgb(30, 41, 59);
            txtAccountStatusVal.Location = new Point(165, 4);
            txtAccountStatusVal.Name = "txtAccountStatusVal";
            txtAccountStatusVal.ReadOnly = true;
            txtAccountStatusVal.Size = new Size(320, 29);
            txtAccountStatusVal.TabIndex = 1;
            txtAccountStatusVal.Text = "Active (Verified)";
            // 
            // pnlLastLogin
            // 
            pnlLastLogin.Controls.Add(lblLastLoginKey);
            pnlLastLogin.Controls.Add(txtLastLoginVal);
            pnlLastLogin.Location = new Point(10, 298);
            pnlLastLogin.Margin = new Padding(0, 2, 0, 2);
            pnlLastLogin.Name = "pnlLastLogin";
            pnlLastLogin.Size = new Size(500, 32);
            pnlLastLogin.TabIndex = 7;
            // 
            // lblLastLoginKey
            // 
            lblLastLoginKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLastLoginKey.ForeColor = Color.FromArgb(100, 116, 139);
            lblLastLoginKey.Location = new Point(0, 6);
            lblLastLoginKey.Name = "lblLastLoginKey";
            lblLastLoginKey.Size = new Size(160, 20);
            lblLastLoginKey.TabIndex = 0;
            lblLastLoginKey.Text = "Last Login:";
            // 
            // txtLastLoginVal
            // 
            txtLastLoginVal.BackColor = Color.FromArgb(245, 247, 250);
            txtLastLoginVal.BorderStyle = BorderStyle.FixedSingle;
            txtLastLoginVal.Font = new Font("Segoe UI", 9.5F);
            txtLastLoginVal.ForeColor = Color.FromArgb(30, 41, 59);
            txtLastLoginVal.Location = new Point(165, 4);
            txtLastLoginVal.Name = "txtLastLoginVal";
            txtLastLoginVal.ReadOnly = true;
            txtLastLoginVal.Size = new Size(320, 29);
            txtLastLoginVal.TabIndex = 1;
            txtLastLoginVal.Text = "03 November 2026 - 02:56 PM";
            // 
            // actionsPanel
            // 
            actionsPanel.BackColor = Color.Transparent;
            actionsPanel.Controls.Add(btnChangePassword);
            actionsPanel.Dock = DockStyle.Bottom;
            actionsPanel.Location = new Point(25, 519);
            actionsPanel.Name = "actionsPanel";
            actionsPanel.Size = new Size(1225, 50);
            actionsPanel.TabIndex = 1;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(14, 116, 144);
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(10, 8);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(160, 36);
            btnChangePassword.TabIndex = 0;
            btnChangePassword.Text = "🔒 Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(15, 23, 42);
            headerPanel.Controls.Add(lblAvatar);
            headerPanel.Controls.Add(lblName);
            headerPanel.Controls.Add(lblRole);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(25, 25);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(20);
            headerPanel.Size = new Size(1225, 90);
            headerPanel.TabIndex = 2;
            // 
            // lblAvatar
            // 
            lblAvatar.AutoSize = true;
            lblAvatar.Font = new Font("Segoe UI", 32F);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location = new Point(15, 10);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(104, 72);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "👤";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(154, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(208, 37);
            lblName.TabIndex = 1;
            lblName.Text = "Mohamed Elsisi";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9.5F);
            lblRole.ForeColor = Color.FromArgb(6, 182, 212);
            lblRole.Location = new Point(154, 52);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(341, 21);
            lblRole.TabIndex = 2;
            lblRole.Text = "System Administrator | .NET Backend Developer";
            lblRole.Click += lblRole_Click;
            // 
            // ProfileControl
            // 
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(cardPanel);
            Name = "ProfileControl";
            Padding = new Padding(20);
            Size = new Size(1315, 634);
            cardPanel.ResumeLayout(false);
            flowPanel.ResumeLayout(false);
            flowPanel.PerformLayout();
            pnlFullName.ResumeLayout(false);
            pnlFullName.PerformLayout();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            pnlPhone.ResumeLayout(false);
            pnlPhone.PerformLayout();
            pnlSystemRole.ResumeLayout(false);
            pnlSystemRole.PerformLayout();
            pnlAccountStatus.ResumeLayout(false);
            pnlAccountStatus.PerformLayout();
            pnlLastLogin.ResumeLayout(false);
            pnlLastLogin.PerformLayout();
            actionsPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}