using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    public partial class AdminDashboardControl : UserControl
    {
        private DataTable adminsTable = null!;
        private readonly string[] adminFields = new[] { "Admin ID", "Full Name", "Email Address", "Role Permission", "Status" };

        public AdminDashboardControl()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                ApplyThemeStyles();
                ConfigureGridStyle();
                SetupGridRowEvents();
            }
        }

        private void ApplyThemeStyles()
        {
            this.BackColor = ThemePalette.CanvasBackground;
            leftPanel.BackColor = ThemePalette.CardBackground;
            lblTableTitle.ForeColor = ThemePalette.TextPrimary;

            cardRevenue.BackColor = ThemePalette.CardBackground;
            cardAdmins.BackColor = ThemePalette.CardBackground;
            cardCourses.BackColor = ThemePalette.CardBackground;
            cardPending.BackColor = ThemePalette.CardBackground;

            cardRevenueBar.BackColor = ThemePalette.OceanBlue;
            cardAdminsBar.BackColor = ThemePalette.CyanAzure;
            cardCoursesBar.BackColor = ThemePalette.SteelTeal;
            cardPendingBar.BackColor = ThemePalette.PetrolTeal;

            btnOpenAddModal.BackColor = ThemePalette.OceanBlue;
        }

        private void ConfigureGridStyle()
        {
            DataGridView styled = ThemePalette.CreateStyledGrid();
            gridAdmins.AutoSizeColumnsMode = styled.AutoSizeColumnsMode;
            gridAdmins.SelectionMode = styled.SelectionMode;
            gridAdmins.MultiSelect = styled.MultiSelect;
            gridAdmins.ReadOnly = styled.ReadOnly;
            gridAdmins.AllowUserToAddRows = styled.AllowUserToAddRows;
            gridAdmins.AllowUserToDeleteRows = styled.AllowUserToDeleteRows;
            gridAdmins.AllowUserToResizeRows = styled.AllowUserToResizeRows;
            gridAdmins.EnableHeadersVisualStyles = styled.EnableHeadersVisualStyles;
            gridAdmins.ColumnHeadersDefaultCellStyle = styled.ColumnHeadersDefaultCellStyle;
            gridAdmins.DefaultCellStyle = styled.DefaultCellStyle;
        }

        private void SetupGridRowEvents()
        {
            gridAdmins.CellFormatting += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == gridAdmins.Columns["colView"]?.Index) { e.CellStyle.BackColor = ThemePalette.OceanBlue; e.CellStyle.ForeColor = Color.White; }
                    else if (e.ColumnIndex == gridAdmins.Columns["colUpdate"]?.Index) { e.CellStyle.BackColor = ThemePalette.SteelTeal; e.CellStyle.ForeColor = Color.White; }
                    else if (e.ColumnIndex == gridAdmins.Columns["colDelete"]?.Index) { e.CellStyle.BackColor = Color.FromArgb(180, 40, 40); e.CellStyle.ForeColor = Color.White; }
                }
            };

            gridAdmins.CellContentClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.RowIndex < gridAdmins.Rows.Count)
                {
                    var row = gridAdmins.Rows[e.RowIndex];
                    string adminName = row.Cells["colFullName"].Value?.ToString() ?? "";

                    if (e.ColumnIndex == gridAdmins.Columns["colView"]?.Index)
                    {
                        MessageBox.Show($"Viewing details for Admin: {adminName}", "Admin Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (e.ColumnIndex == gridAdmins.Columns["colUpdate"]?.Index)
                    {
                        new EntityCrudModalForm($"Update Admin - {adminName}", adminFields).ShowDialog();
                    }
                    else if (e.ColumnIndex == gridAdmins.Columns["colDelete"]?.Index)
                    {
                        if (MessageBox.Show($"Delete Admin '{adminName}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            gridAdmins.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            };
        }

        private void btnOpenAddModal_Click(object? sender, EventArgs e)
        {
            new EntityCrudModalForm("Create New Admin Record", adminFields).ShowDialog();
        }

        private void gridHeaderBar_Resize(object? sender, EventArgs e)
        {
            if (btnOpenAddModal != null && gridHeaderBar != null)
            {
                btnOpenAddModal.Location = new Point(gridHeaderBar.Width - 165, 4);
            }
        }
    }
}