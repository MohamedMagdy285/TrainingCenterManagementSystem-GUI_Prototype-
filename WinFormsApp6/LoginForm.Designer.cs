using System.Drawing;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel mainLayout = null!;
        private Panel leftHeroPanel = null!;
        private Label lblBrandLogo = null!;
        private Label lblQuote = null!;

        private Panel rightFormPanel = null!;
        private FlowLayoutPanel formFlowPanel = null!;
        private Label lblWelcome = null!;
        private Label lblSubHeader = null!;

        private Panel pnlNameGroup = null!;
        private Label lblNameFloating = null!;
        private Label lblNameIcon = null!;
        private TextBox txtName = null!;

        private Panel pnlEmailGroup = null!;
        private Label lblEmailFloating = null!;
        private Label lblEmailIcon = null!;
        private TextBox txtEmail = null!;

        private Panel pnlPasswordGroup = null!;
        private Label lblPasswordFloating = null!;
        private Label lblPasswordIcon = null!;
        private TextBox txtPassword = null!;

        private LinkLabel lblForgotPassword = null!;
        private Button btnSubmit = null!;
        private Panel pnlDivider = null!;
        private Panel pnlSocialGroup = null!;
        private Button btnGoogle = null!;
        private Button btnFb = null!;
        private Button btnApple = null!;
        private Label lblToggleMode = null!;

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
            mainLayout = new TableLayoutPanel();
            leftHeroPanel = new Panel();
            lblBrandLogo = new Label();
            lblQuote = new Label();
            rightFormPanel = new Panel();
            formFlowPanel = new FlowLayoutPanel();
            lblWelcome = new Label();
            lblSubHeader = new Label();
            pnlNameGroup = new Panel();
            lblNameFloating = new Label();
            lblNameIcon = new Label();
            txtName = new TextBox();
            pnlEmailGroup = new Panel();
            lblEmailFloating = new Label();
            lblEmailIcon = new Label();
            txtEmail = new TextBox();
            pnlPasswordGroup = new Panel();
            lblPasswordFloating = new Label();
            lblPasswordIcon = new Label();
            txtPassword = new TextBox();
            lblForgotPassword = new LinkLabel();
            btnSubmit = new Button();
            pnlDivider = new Panel();
            pnlSocialGroup = new Panel();
            btnGoogle = new Button();
            btnFb = new Button();
            btnApple = new Button();
            lblToggleMode = new Label();
            mainLayout.SuspendLayout();
            leftHeroPanel.SuspendLayout();
            rightFormPanel.SuspendLayout();
            formFlowPanel.SuspendLayout();
            pnlNameGroup.SuspendLayout();
            pnlEmailGroup.SuspendLayout();
            pnlPasswordGroup.SuspendLayout();
            pnlSocialGroup.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            mainLayout.Controls.Add(leftHeroPanel, 0, 0);
            mainLayout.Controls.Add(rightFormPanel, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout.Size = new Size(998, 604);
            mainLayout.TabIndex = 0;
            // 
            // leftHeroPanel
            // 
            leftHeroPanel.BackColor = Color.FromArgb(10, 25, 47);
            leftHeroPanel.Controls.Add(lblBrandLogo);
            leftHeroPanel.Controls.Add(lblQuote);
            leftHeroPanel.Dock = DockStyle.Fill;
            leftHeroPanel.Location = new Point(3, 3);
            leftHeroPanel.Name = "leftHeroPanel";
            leftHeroPanel.Size = new Size(443, 598);
            leftHeroPanel.TabIndex = 0;
            leftHeroPanel.Paint += DrawHeroBackground;
            // 
            // lblBrandLogo
            // 
            lblBrandLogo.AutoSize = true;
            lblBrandLogo.BackColor = Color.Transparent;
            lblBrandLogo.Font = new Font("Georgia", 28F, FontStyle.Bold | FontStyle.Italic);
            lblBrandLogo.ForeColor = Color.White;
            lblBrandLogo.Location = new Point(40, 50);
            lblBrandLogo.Name = "lblBrandLogo";
            lblBrandLogo.Size = new Size(368, 54);
            lblBrandLogo.TabIndex = 0;
            lblBrandLogo.Text = "Academy Hub";
            // 
            // lblQuote
            // 
            lblQuote.BackColor = Color.Transparent;
            lblQuote.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblQuote.ForeColor = Color.FromArgb(210, 230, 245);
            lblQuote.Location = new Point(40, 120);
            lblQuote.Name = "lblQuote";
            lblQuote.Size = new Size(340, 60);
            lblQuote.TabIndex = 1;
            lblQuote.Text = "\"Education is the most powerful investment\nthat enriches you beyond material boundaries.\"";
            // 
            // rightFormPanel
            // 
            rightFormPanel.BackColor = Color.White;
            rightFormPanel.Controls.Add(formFlowPanel);
            rightFormPanel.Dock = DockStyle.Fill;
            rightFormPanel.Location = new Point(452, 3);
            rightFormPanel.Name = "rightFormPanel";
            rightFormPanel.Padding = new Padding(40, 30, 40, 20);
            rightFormPanel.Size = new Size(543, 598);
            rightFormPanel.TabIndex = 1;
            rightFormPanel.Paint += DrawRightDecorations;
            // 
            // formFlowPanel
            // 
            formFlowPanel.BackColor = Color.Transparent;
            formFlowPanel.Controls.Add(lblWelcome);
            formFlowPanel.Controls.Add(lblSubHeader);
            formFlowPanel.Controls.Add(pnlNameGroup);
            formFlowPanel.Controls.Add(pnlEmailGroup);
            formFlowPanel.Controls.Add(pnlPasswordGroup);
            formFlowPanel.Controls.Add(lblForgotPassword);
            formFlowPanel.Controls.Add(btnSubmit);
            formFlowPanel.Controls.Add(pnlDivider);
            formFlowPanel.Controls.Add(pnlSocialGroup);
            formFlowPanel.Controls.Add(lblToggleMode);
            formFlowPanel.Dock = DockStyle.Fill;
            formFlowPanel.FlowDirection = FlowDirection.TopDown;
            formFlowPanel.Location = new Point(40, 30);
            formFlowPanel.Name = "formFlowPanel";
            formFlowPanel.Size = new Size(463, 548);
            formFlowPanel.TabIndex = 0;
            formFlowPanel.WrapContents = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(6, 182, 212);
            lblWelcome.Location = new Point(0, 10);
            lblWelcome.Margin = new Padding(0, 10, 0, 2);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(217, 60);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // lblSubHeader
            // 
            lblSubHeader.AutoSize = true;
            lblSubHeader.Font = new Font("Segoe UI", 9.5F);
            lblSubHeader.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubHeader.Location = new Point(0, 72);
            lblSubHeader.Margin = new Padding(0, 0, 0, 15);
            lblSubHeader.Name = "lblSubHeader";
            lblSubHeader.Size = new Size(125, 21);
            lblSubHeader.TabIndex = 1;
            lblSubHeader.Text = "Login with Email";
            // 
            // pnlNameGroup
            // 
            pnlNameGroup.BackColor = Color.White;
            pnlNameGroup.Controls.Add(lblNameFloating);
            pnlNameGroup.Controls.Add(lblNameIcon);
            pnlNameGroup.Controls.Add(txtName);
            pnlNameGroup.Location = new Point(0, 113);
            pnlNameGroup.Margin = new Padding(0, 5, 0, 10);
            pnlNameGroup.Name = "pnlNameGroup";
            pnlNameGroup.Size = new Size(320, 52);
            pnlNameGroup.TabIndex = 2;
            pnlNameGroup.Visible = false;
            pnlNameGroup.Paint += InputGroup_Paint;
            // 
            // lblNameFloating
            // 
            lblNameFloating.AutoSize = true;
            lblNameFloating.BackColor = Color.White;
            lblNameFloating.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblNameFloating.ForeColor = Color.FromArgb(14, 116, 144);
            lblNameFloating.Location = new Point(14, 0);
            lblNameFloating.Name = "lblNameFloating";
            lblNameFloating.Size = new Size(88, 20);
            lblNameFloating.TabIndex = 0;
            lblNameFloating.Text = " Full Name ";
            // 
            // lblNameIcon
            // 
            lblNameIcon.Font = new Font("Segoe UI", 11F);
            lblNameIcon.ForeColor = Color.FromArgb(15, 118, 110);
            lblNameIcon.Location = new Point(10, 18);
            lblNameIcon.Name = "lblNameIcon";
            lblNameIcon.Size = new Size(24, 22);
            lblNameIcon.TabIndex = 1;
            lblNameIcon.Text = "👤";
            lblNameIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 10.5F);
            txtName.ForeColor = Color.FromArgb(30, 41, 59);
            txtName.Location = new Point(38, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 24);
            txtName.TabIndex = 2;
            // 
            // pnlEmailGroup
            // 
            pnlEmailGroup.BackColor = Color.White;
            pnlEmailGroup.Controls.Add(lblEmailFloating);
            pnlEmailGroup.Controls.Add(lblEmailIcon);
            pnlEmailGroup.Controls.Add(txtEmail);
            pnlEmailGroup.Location = new Point(0, 180);
            pnlEmailGroup.Margin = new Padding(0, 5, 0, 10);
            pnlEmailGroup.Name = "pnlEmailGroup";
            pnlEmailGroup.Size = new Size(320, 52);
            pnlEmailGroup.TabIndex = 3;
            pnlEmailGroup.Paint += InputGroup_Paint;
            // 
            // lblEmailFloating
            // 
            lblEmailFloating.AutoSize = true;
            lblEmailFloating.BackColor = Color.White;
            lblEmailFloating.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEmailFloating.ForeColor = Color.FromArgb(14, 116, 144);
            lblEmailFloating.Location = new Point(14, 0);
            lblEmailFloating.Name = "lblEmailFloating";
            lblEmailFloating.Size = new Size(73, 20);
            lblEmailFloating.TabIndex = 0;
            lblEmailFloating.Text = " Email Id ";
            // 
            // lblEmailIcon
            // 
            lblEmailIcon.Font = new Font("Segoe UI", 11F);
            lblEmailIcon.ForeColor = Color.FromArgb(15, 118, 110);
            lblEmailIcon.Location = new Point(10, 18);
            lblEmailIcon.Name = "lblEmailIcon";
            lblEmailIcon.Size = new Size(24, 22);
            lblEmailIcon.TabIndex = 1;
            lblEmailIcon.Text = "✉";
            lblEmailIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 10.5F);
            txtEmail.ForeColor = Color.FromArgb(30, 41, 59);
            txtEmail.Location = new Point(38, 20);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 24);
            txtEmail.TabIndex = 2;
            // 
            // pnlPasswordGroup
            // 
            pnlPasswordGroup.BackColor = Color.White;
            pnlPasswordGroup.Controls.Add(lblPasswordFloating);
            pnlPasswordGroup.Controls.Add(lblPasswordIcon);
            pnlPasswordGroup.Controls.Add(txtPassword);
            pnlPasswordGroup.Location = new Point(0, 247);
            pnlPasswordGroup.Margin = new Padding(0, 5, 0, 10);
            pnlPasswordGroup.Name = "pnlPasswordGroup";
            pnlPasswordGroup.Size = new Size(320, 52);
            pnlPasswordGroup.TabIndex = 4;
            pnlPasswordGroup.Paint += InputGroup_Paint;
            // 
            // lblPasswordFloating
            // 
            lblPasswordFloating.AutoSize = true;
            lblPasswordFloating.BackColor = Color.White;
            lblPasswordFloating.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPasswordFloating.ForeColor = Color.FromArgb(14, 116, 144);
            lblPasswordFloating.Location = new Point(14, 0);
            lblPasswordFloating.Name = "lblPasswordFloating";
            lblPasswordFloating.Size = new Size(84, 20);
            lblPasswordFloating.TabIndex = 0;
            lblPasswordFloating.Text = " Password ";
            // 
            // lblPasswordIcon
            // 
            lblPasswordIcon.Font = new Font("Segoe UI", 11F);
            lblPasswordIcon.ForeColor = Color.FromArgb(15, 118, 110);
            lblPasswordIcon.Location = new Point(10, 18);
            lblPasswordIcon.Name = "lblPasswordIcon";
            lblPasswordIcon.Size = new Size(24, 22);
            lblPasswordIcon.TabIndex = 1;
            lblPasswordIcon.Text = "🔒";
            lblPasswordIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10.5F);
            txtPassword.ForeColor = Color.FromArgb(30, 41, 59);
            txtPassword.Location = new Point(38, 20);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(265, 24);
            txtPassword.TabIndex = 2;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.ActiveLinkColor = Color.FromArgb(14, 116, 144);
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Cursor = Cursors.Hand;
            lblForgotPassword.Font = new Font("Segoe UI", 9F);
            lblForgotPassword.LinkColor = Color.FromArgb(100, 116, 139);
            lblForgotPassword.Location = new Point(180, 309);
            lblForgotPassword.Margin = new Padding(180, 0, 0, 15);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(160, 20);
            lblForgotPassword.TabIndex = 5;
            lblForgotPassword.TabStop = true;
            lblForgotPassword.Text = "Forgot your password?";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(14, 116, 144);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(0, 349);
            btnSubmit.Margin = new Padding(0, 5, 0, 15);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(320, 44);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "LOGIN";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pnlDivider
            // 
            pnlDivider.Location = new Point(0, 413);
            pnlDivider.Margin = new Padding(0, 5, 0, 10);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(320, 20);
            pnlDivider.TabIndex = 7;
            pnlDivider.Paint += pnlDivider_Paint;
            // 
            // pnlSocialGroup
            // 
            pnlSocialGroup.Controls.Add(btnGoogle);
            pnlSocialGroup.Controls.Add(btnFb);
            pnlSocialGroup.Controls.Add(btnApple);
            pnlSocialGroup.Location = new Point(0, 443);
            pnlSocialGroup.Margin = new Padding(0, 0, 0, 10);
            pnlSocialGroup.Name = "pnlSocialGroup";
            pnlSocialGroup.Size = new Size(320, 42);
            pnlSocialGroup.TabIndex = 8;
            // 
            // btnGoogle
            // 
            btnGoogle.BackColor = Color.FromArgb(240, 245, 248);
            btnGoogle.Cursor = Cursors.Hand;
            btnGoogle.FlatAppearance.BorderSize = 0;
            btnGoogle.FlatStyle = FlatStyle.Flat;
            btnGoogle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGoogle.ForeColor = Color.FromArgb(220, 60, 50);
            btnGoogle.Location = new Point(30, 0);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new Size(70, 38);
            btnGoogle.TabIndex = 0;
            btnGoogle.Text = "G";
            btnGoogle.UseVisualStyleBackColor = false;
            // 
            // btnFb
            // 
            btnFb.BackColor = Color.FromArgb(240, 245, 248);
            btnFb.Cursor = Cursors.Hand;
            btnFb.FlatAppearance.BorderSize = 0;
            btnFb.FlatStyle = FlatStyle.Flat;
            btnFb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFb.ForeColor = Color.FromArgb(25, 118, 210);
            btnFb.Location = new Point(125, 0);
            btnFb.Name = "btnFb";
            btnFb.Size = new Size(70, 38);
            btnFb.TabIndex = 1;
            btnFb.Text = "f";
            btnFb.UseVisualStyleBackColor = false;
            // 
            // btnApple
            // 
            btnApple.BackColor = Color.FromArgb(240, 245, 248);
            btnApple.Cursor = Cursors.Hand;
            btnApple.FlatAppearance.BorderSize = 0;
            btnApple.FlatStyle = FlatStyle.Flat;
            btnApple.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnApple.ForeColor = Color.Black;
            btnApple.Location = new Point(220, 0);
            btnApple.Name = "btnApple";
            btnApple.Size = new Size(70, 38);
            btnApple.TabIndex = 2;
            btnApple.Text = "";
            btnApple.UseVisualStyleBackColor = false;
            // 
            // lblToggleMode
            // 
            lblToggleMode.AutoSize = true;
            lblToggleMode.Cursor = Cursors.Hand;
            lblToggleMode.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblToggleMode.ForeColor = Color.FromArgb(30, 41, 59);
            lblToggleMode.Location = new Point(50, 510);
            lblToggleMode.Margin = new Padding(50, 15, 0, 0);
            lblToggleMode.Name = "lblToggleMode";
            lblToggleMode.Size = new Size(270, 21);
            lblToggleMode.TabIndex = 9;
            lblToggleMode.Text = "Don't have account? Register Now";
            lblToggleMode.Click += lblToggleMode_Click;
            // 
            // LoginForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(998, 604);
            Controls.Add(mainLayout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(900, 580);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Training Center - Authentication";
            mainLayout.ResumeLayout(false);
            leftHeroPanel.ResumeLayout(false);
            leftHeroPanel.PerformLayout();
            rightFormPanel.ResumeLayout(false);
            formFlowPanel.ResumeLayout(false);
            formFlowPanel.PerformLayout();
            pnlNameGroup.ResumeLayout(false);
            pnlNameGroup.PerformLayout();
            pnlEmailGroup.ResumeLayout(false);
            pnlEmailGroup.PerformLayout();
            pnlPasswordGroup.ResumeLayout(false);
            pnlPasswordGroup.PerformLayout();
            pnlSocialGroup.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}