using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    public partial class EntityDetailsModalForm : Form
    {
        private string? currentVideoUrl;

        // Constructor افتراضي لدعم Visual Studio Designer
        public EntityDetailsModalForm()
        {
            InitializeComponent();
        }

        public EntityDetailsModalForm(
            string title,
            string badge,
            string mainName,
            (string Key, string Val)[] metrics,
            (string Key, string Val)[] details,
            string sectionTitle,
            string sectionText,
            string? videoTitle = null,
            string? videoUrl = null) : this()
        {
            this.Text = $"{title} - {badge}";
            this.Size = new Size(520, string.IsNullOrEmpty(videoTitle) ? 530 : 630);
            this.currentVideoUrl = videoUrl;

            // تطبيق ثيمات الألوان الديناميكية
            ApplyThemeStyles();

            lblBadge.Text = badge;
            lblTitle.Text = mainName;

            // Populate KPI Metrics
            if (metrics != null && metrics.Length > 0)
            {
                metricsGrid.Visible = true;
                if (metrics.Length >= 1) { lblMetricKey1.Text = metrics[0].Key; lblMetricVal1.Text = metrics[0].Val; }
                if (metrics.Length >= 2) { lblMetricKey2.Text = metrics[1].Key; lblMetricVal2.Text = metrics[1].Val; }
                if (metrics.Length >= 3) { lblMetricKey3.Text = metrics[2].Key; lblMetricVal3.Text = metrics[2].Val; }
            }
            else
            {
                metricsGrid.Visible = false;
            }

            // Populate Key-Value Rows
            Panel[] rowPanels = new[] { pnlRow1, pnlRow2, pnlRow3, pnlRow4 };
            Label[] keyLabels = new[] { lblKey1, lblKey2, lblKey3, lblKey4 };
            Label[] valLabels = new[] { lblVal1, lblVal2, lblVal3, lblVal4 };

            for (int i = 0; i < rowPanels.Length; i++)
            {
                if (details != null && i < details.Length)
                {
                    rowPanels[i].Visible = true;
                    keyLabels[i].Text = details[i].Key;
                    valLabels[i].Text = details[i].Val;
                }
                else
                {
                    rowPanels[i].Visible = false;
                }
            }

            // Description Section
            if (!string.IsNullOrEmpty(sectionText))
            {
                lblSectionTitle.Visible = true;
                txtSectionText.Visible = true;
                lblSectionTitle.Text = sectionTitle;
                txtSectionText.Text = sectionText;
            }
            else
            {
                lblSectionTitle.Visible = false;
                txtSectionText.Visible = false;
            }

            // Video Preview Section
            if (!string.IsNullOrEmpty(videoTitle))
            {
                lblVideoSectionHeader.Visible = true;
                pnlVideoCard.Visible = true;
                lblVidTitle.Text = videoTitle;
                btnPlay.Click += BtnPlay_Click;
            }
            else
            {
                lblVideoSectionHeader.Visible = false;
                pnlVideoCard.Visible = false;
            }
        }

        private void ApplyThemeStyles()
        {
            this.BackColor = ThemePalette.CanvasBackground;
            headerPanel.BackColor = ThemePalette.MidnightNavy;
            lblBadge.BackColor = ThemePalette.OceanBlue;
            btnClose.BackColor = ThemePalette.SteelTeal;

            pnlMetric1.BackColor = ThemePalette.CardBackground;
            pnlMetric2.BackColor = ThemePalette.CardBackground;
            pnlMetric3.BackColor = ThemePalette.CardBackground;

            pnlMetricBar1.BackColor = ThemePalette.SteelTeal;
            pnlMetricBar2.BackColor = ThemePalette.CyanAzure;
            pnlMetricBar3.BackColor = ThemePalette.OceanBlue;

            lblMetricKey1.ForeColor = ThemePalette.TextMuted;
            lblMetricKey2.ForeColor = ThemePalette.TextMuted;
            lblMetricKey3.ForeColor = ThemePalette.TextMuted;

            lblMetricVal1.ForeColor = ThemePalette.TextPrimary;
            lblMetricVal2.ForeColor = ThemePalette.TextPrimary;
            lblMetricVal3.ForeColor = ThemePalette.TextPrimary;

            lblKey1.ForeColor = ThemePalette.TextMuted;
            lblKey2.ForeColor = ThemePalette.TextMuted;
            lblKey3.ForeColor = ThemePalette.TextMuted;
            lblKey4.ForeColor = ThemePalette.TextMuted;

            lblVal1.ForeColor = ThemePalette.TextPrimary;
            lblVal2.ForeColor = ThemePalette.TextPrimary;
            lblVal3.ForeColor = ThemePalette.TextPrimary;
            lblVal4.ForeColor = ThemePalette.TextPrimary;

            lblSectionTitle.ForeColor = ThemePalette.TextPrimary;
            txtSectionText.BackColor = ThemePalette.CardBackground;
            txtSectionText.ForeColor = ThemePalette.TextPrimary;

            lblVideoSectionHeader.ForeColor = ThemePalette.TextPrimary;
            pnlVideoCard.BackColor = ThemePalette.MidnightNavy;
            lblPlayIcon.ForeColor = ThemePalette.CyanAzure;
            btnPlay.BackColor = ThemePalette.OceanBlue;
        }

        private void BtnPlay_Click(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentVideoUrl) && (currentVideoUrl.StartsWith("http://") || currentVideoUrl.StartsWith("https://")))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(currentVideoUrl) { UseShellExecute = true });
                }
                catch
                {
                    MessageBox.Show($"Opening video: {currentVideoUrl}", "Video Player");
                }
            }
            else
            {
                MessageBox.Show($"Playing video preview for: {lblTitle.Text}", "Media Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}