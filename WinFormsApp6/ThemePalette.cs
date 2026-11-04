using System.Drawing;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    public static class ThemePalette
    {
        // Core Palette Colors
        public static readonly Color MidnightNavy = Color.FromArgb(10, 25, 47);
        public static readonly Color OceanBlue = Color.FromArgb(14, 116, 144);
        public static readonly Color SteelTeal = Color.FromArgb(15, 118, 110);
        public static readonly Color CyanAzure = Color.FromArgb(6, 182, 212);
        public static readonly Color PetrolTeal = Color.FromArgb(20, 83, 93);

        // Backgrounds & Text
        public static readonly Color CanvasBackground = Color.FromArgb(245, 247, 250);
        public static readonly Color CardBackground = Color.White;
        public static readonly Color TextPrimary = Color.FromArgb(30, 41, 59);
        public static readonly Color TextMuted = Color.FromArgb(100, 116, 139);

        // Universal DataGridView Factory Method
        public static DataGridView CreateStyledGrid()
        {
            DataGridView grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = CardBackground,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = Color.FromArgb(226, 232, 240),
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                ReadOnly = true,
                AutoGenerateColumns = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                EnableHeadersVisualStyles = false
            };

            grid.ColumnHeadersDefaultCellStyle.BackColor = MidnightNavy;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            grid.ColumnHeadersHeight = 40;

            grid.DefaultCellStyle.BackColor = CardBackground;
            grid.DefaultCellStyle.ForeColor = TextPrimary;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 242, 254);
            grid.DefaultCellStyle.SelectionForeColor = TextPrimary;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            grid.RowTemplate.Height = 36;

            return grid;
        }
    }
}