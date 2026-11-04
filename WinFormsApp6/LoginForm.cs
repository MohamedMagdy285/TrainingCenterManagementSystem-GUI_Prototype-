using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    public partial class LoginForm : Form
    {
        private bool isRegisterMode = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblToggleMode_Click(object? sender, EventArgs e)
        {
            isRegisterMode = !isRegisterMode;

            if (isRegisterMode)
            {
                lblWelcome.Text = "Create Account";
                lblSubHeader.Text = "Register with Email";
                pnlNameGroup.Visible = true;
                lblForgotPassword.Visible = false;
                btnSubmit.Text = "REGISTER NOW";
                lblToggleMode.Text = "Already have an account? Login Here";
            }
            else
            {
                lblWelcome.Text = "Welcome";
                lblSubHeader.Text = "Login with Email";
                pnlNameGroup.Visible = false;
                lblForgotPassword.Visible = true;
                btnSubmit.Text = "LOGIN";
                lblToggleMode.Text = "Don't have account? Register Now";
            }
        }

        private void btnSubmit_Click(object? sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void InputGroup_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is Panel outer)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(ThemePalette.CyanAzure, 1.5f))
                {
                    Rectangle rect = new Rectangle(1, 8, outer.Width - 3, outer.Height - 12);
                    GraphicsPath path = GetRoundedRectPath(rect, 8);
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void pnlDivider_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is Panel pnl)
            {
                int midY = pnl.Height / 2;
                using (Pen pen = new Pen(Color.FromArgb(220, 225, 230), 1))
                {
                    e.Graphics.DrawLine(pen, 0, midY, 130, midY);
                    e.Graphics.DrawLine(pen, 190, midY, 320, midY);
                }
                using (Font font = new Font("Segoe UI", 8.5F, FontStyle.Bold))
                using (Brush brush = new SolidBrush(ThemePalette.TextMuted))
                {
                    e.Graphics.DrawString("OR", font, brush, 148, midY - 8);
                }
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void DrawHeroBackground(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (LinearGradientBrush lgb = new LinearGradientBrush(
                leftHeroPanel.ClientRectangle,
                ThemePalette.MidnightNavy,
                ThemePalette.PetrolTeal,
                45f))
            {
                g.FillRectangle(lgb, leftHeroPanel.ClientRectangle);
            }

            using (Pen pen = new Pen(Color.FromArgb(30, 255, 255, 255), 2))
            {
                g.DrawArc(pen, -100, 150, 400, 400, 0, 180);
                g.DrawArc(pen, 50, 200, 350, 350, 45, 180);
            }
        }

        private void DrawRightDecorations(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen dottedPen = new Pen(ThemePalette.CyanAzure, 1.5f))
            {
                dottedPen.DashStyle = DashStyle.Dot;
                g.DrawArc(dottedPen, rightFormPanel.Width - 140, 20, 100, 60, 180, 120);
            }

            int baseY = rightFormPanel.Height - 35;
            using (Brush skyBrush = new SolidBrush(ThemePalette.CyanAzure))
            {
                g.FillRectangle(skyBrush, 10, baseY - 25, 25, 25);
                g.FillPie(skyBrush, 12, baseY - 35, 21, 20, 180, 180);
                g.FillRectangle(skyBrush, 38, baseY - 40, 8, 40);

                int rX = rightFormPanel.Width - 80;
                g.FillRectangle(skyBrush, rX, baseY - 45, 18, 45);
                g.FillRectangle(skyBrush, rX + 22, baseY - 35, 16, 35);
                g.FillRectangle(skyBrush, rX + 42, baseY - 25, 20, 25);
            }
        }
    }
}