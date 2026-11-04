using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                ApplyThemeStyles();
                txtLastLoginVal.Text = DateTime.Now.ToString("dd MMMM yyyy - hh:mm tt");
            }
        }

        private void ApplyThemeStyles()
        {
            this.BackColor = ThemePalette.CanvasBackground;
            cardPanel.BackColor = ThemePalette.CardBackground;
            headerPanel.BackColor = ThemePalette.MidnightNavy;
            lblRole.ForeColor = ThemePalette.CyanAzure;

            lblSecPersonal.ForeColor = ThemePalette.OceanBlue;
            lblSecSecurity.ForeColor = ThemePalette.OceanBlue;

            lblFullNameKey.ForeColor = ThemePalette.TextMuted;
            lblEmailKey.ForeColor = ThemePalette.TextMuted;
            lblPhoneKey.ForeColor = ThemePalette.TextMuted;
            lblSystemRoleKey.ForeColor = ThemePalette.TextMuted;
            lblAccountStatusKey.ForeColor = ThemePalette.TextMuted;
            lblLastLoginKey.ForeColor = ThemePalette.TextMuted;

            txtFullNameVal.BackColor = ThemePalette.CanvasBackground;
            txtFullNameVal.ForeColor = ThemePalette.TextPrimary;

            txtEmailVal.BackColor = ThemePalette.CanvasBackground;
            txtEmailVal.ForeColor = ThemePalette.TextPrimary;

            txtPhoneVal.BackColor = ThemePalette.CanvasBackground;
            txtPhoneVal.ForeColor = ThemePalette.TextPrimary;

            txtSystemRoleVal.BackColor = ThemePalette.CanvasBackground;
            txtSystemRoleVal.ForeColor = ThemePalette.TextPrimary;

            txtAccountStatusVal.BackColor = ThemePalette.CanvasBackground;
            txtAccountStatusVal.ForeColor = ThemePalette.TextPrimary;

            txtLastLoginVal.BackColor = ThemePalette.CanvasBackground;
            txtLastLoginVal.ForeColor = ThemePalette.TextPrimary;

            btnChangePassword.BackColor = ThemePalette.OceanBlue;
        }

        private void btnChangePassword_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Password change modal opened.", "Security Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }
    }
}