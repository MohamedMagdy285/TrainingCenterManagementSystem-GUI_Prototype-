using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    public partial class MainForm : Form
    {
        private Button[] navBtns = null!;

        public MainForm()
        {
            InitializeComponent();

            // تطبيق الألوان ديناميكياً من ThemePalette عند التشغيل
            this.BackColor = ThemePalette.CanvasBackground;
            this.sidebarPanel.BackColor = ThemePalette.MidnightNavy;
            this.headerPanel.BackColor = ThemePalette.PetrolTeal;

            navBtns = new Button[] { btnDashboard, btnCourses, btnInstructors, btnMembers, btnApplications, btnProfile };

            // ربط الصفحات عند التشغيل
            if (!this.DesignMode)
            {
                InitializeCustomTabPages();
            }

            SwitchTab(0, "Admin Control Center", btnDashboard);
        }

        private void InitializeCustomTabPages()
        {
            tabDashboard.Controls.Add(new AdminDashboardControl());

            TabPage cPage = CreateCoursesPage();
            TransferControls(cPage, tabCourses);

            TabPage iPage = CreateInstructorsPage();
            TransferControls(iPage, tabInstructors);

            TabPage mPage = CreateMembersPage();
            TransferControls(mPage, tabMembers);

            TabPage aPage = CreateApplicationsPage();
            TransferControls(aPage, tabApplications);

            tabProfile.Controls.Add(new ProfileControl());
        }

        private void TransferControls(TabPage source, TabPage destination)
        {
            while (source.Controls.Count > 0)
            {
                Control ctrl = source.Controls[0];
                destination.Controls.Add(ctrl);
            }
        }

        private void btnDashboard_Click(object? sender, EventArgs e) => SwitchTab(0, "Admin Control Center", btnDashboard);
        private void btnCourses_Click(object? sender, EventArgs e) => SwitchTab(1, "Courses Directory", btnCourses);
        private void btnInstructors_Click(object? sender, EventArgs e) => SwitchTab(2, "Instructors Directory", btnInstructors);
        private void btnMembers_Click(object? sender, EventArgs e) => SwitchTab(3, "Members & Trainees", btnMembers);
        private void btnApplications_Click(object? sender, EventArgs e) => SwitchTab(4, "Enrollment Applications", btnApplications);
        private void btnProfile_Click(object? sender, EventArgs e) => SwitchTab(5, "User Profile & Account Settings", btnProfile);

        private void SwitchTab(int index, string title, Button selectedBtn)
        {
            mainTabControl.SelectedIndex = index;
            lblHeaderTitle.Text = title;
            foreach (var btn in navBtns)
            {
                btn.BackColor = ThemePalette.MidnightNavy;
                btn.ForeColor = Color.FromArgb(190, 205, 220);
                btn.Font = new Font("Segoe UI", 10F);
            }
            selectedBtn.BackColor = ThemePalette.OceanBlue;
            selectedBtn.ForeColor = Color.White;
            selectedBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        }

        private TabPage CreateTabPage(Control content)
        {
            TabPage page = new TabPage { BackColor = ThemePalette.CanvasBackground };
            page.Controls.Add(content);
            return page;
        }

        // --- ENTITY PAGES BUILDERS ---
        private TabPage CreateCoursesPage()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new[] { new DataColumn("Course Code"), new DataColumn("Course Name"), new DataColumn("Category"), new DataColumn("Duration"), new DataColumn("Fee"), new DataColumn("Instructor") });
            dt.Rows.Add("CRS-101", "C# .NET Core Masterclass", "Backend Architecture", "45 Hours", "$299.00", "Dr. Alan Turing");
            dt.Rows.Add("CRS-102", "AWS Cloud Infrastructure & DevOps", "Cloud Computing", "60 Hours", "$450.00", "Sarah Connor");
            dt.Rows.Add("CRS-103", "UI/UX & System Design Principles", "Product Design", "30 Hours", "$199.00", "Marcus Aurelius");

            return BuildEntityPage("Courses", dt, new[] { "Course Code", "Course Name", "Category", "Duration", "Fee", "Instructor" }, (r) =>
            {
                new EntityDetailsModalForm(
                    "Course Details",
                    r["Course Code"].ToString()!,
                    r["Course Name"].ToString()!,
                    new[] { ("Category", r["Category"].ToString()!), ("Duration", r["Duration"].ToString()!), ("Fee", r["Fee"].ToString()!) },
                    new[] { ("Assigned Instructor:", r["Instructor"].ToString()!), ("Schedule:", "Tues & Thurs (6-9 PM)") },
                    "Course Description:",
                    $"Comprehensive training covering {r["Course Name"]}.",
                    $"{r["Course Name"]} - Syllabus Preview",
                    "https://youtube.com"
                ).ShowDialog();
            });
        }

        private TabPage CreateInstructorsPage()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new[] { new DataColumn("Instructor ID"), new DataColumn("Full Name"), new DataColumn("Specialization"), new DataColumn("Email"), new DataColumn("Hourly Rate") });
            dt.Rows.Add("INS-001", "Dr. Alan Turing", "Software Architecture & C#", "alan.turing@academy.com", "$85.00");
            dt.Rows.Add("INS-002", "Sarah Connor", "AWS Cloud & Cyber Security", "sarah.connor@academy.com", "$95.00");
            dt.Rows.Add("INS-003", "Marcus Aurelius", "Design Systems & UI/UX", "marcus.a@academy.com", "$75.00");

            return BuildEntityPage("Instructors", dt, new[] { "Instructor ID", "Full Name", "Specialization", "Email", "Hourly Rate" }, (r) =>
            {
                new EntityDetailsModalForm("Instructor Details", r["Instructor ID"].ToString()!, r["Full Name"].ToString()!,
                    new[] { ("Specialization", r["Specialization"].ToString()!), ("Hourly Rate", r["Hourly Rate"].ToString()!), ("Status", "Active Staff") },
                    new[] { ("Email Address:", r["Email"].ToString()!), ("Office Hours:", "Mon & Wed (2-5 PM)") },
                    "Professional Bio:", $"{r["Full Name"]} is a senior instructor specializing in {r["Specialization"]}.").ShowDialog();
            });
        }

        private TabPage CreateMembersPage()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new[] { new DataColumn("Member ID"), new DataColumn("Member Name"), new DataColumn("Email Address"), new DataColumn("Phone Number"), new DataColumn("Membership Tier") });
            dt.Rows.Add("MBR-2026-01", "Mohamed Elsisi", "mohamed.elsisi@dev.io", "+20 101 234 5678", "Premium Student");
            dt.Rows.Add("MBR-2026-02", "Elena Rostova", "elena.rostova@gmail.com", "+1 (555) 012-4411", "Professional");
            dt.Rows.Add("MBR-2026-03", "David Miller", "david.m@corporate.com", "+44 20 7946 0912", "Enterprise");

            return BuildEntityPage("Members", dt, new[] { "Member ID", "Member Name", "Email Address", "Phone Number", "Membership Tier" }, (r) =>
            {
                new EntityDetailsModalForm("Member Details", r["Member ID"].ToString()!, r["Member Name"].ToString()!,
                    new[] { ("Tier", r["Membership Tier"].ToString()!), ("Account Status", "Active"), ("Attendance", "96%") },
                    new[] { ("Email Address:", r["Email Address"].ToString()!), ("Phone Number:", r["Phone Number"].ToString()!) },
                    "", "").ShowDialog();
            });
        }

        private TabPage CreateApplicationsPage()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new[] { new DataColumn("Application ID"), new DataColumn("Applicant Name"), new DataColumn("Target Course"), new DataColumn("Date"), new DataColumn("Status") });
            dt.Rows.Add("APP-9011", "Mohamed Elsisi", "C# .NET Core Masterclass", "2026-10-28", "Approved");
            dt.Rows.Add("APP-9012", "Elena Rostova", "AWS Cloud Infrastructure", "2026-11-01", "Pending Review");
            dt.Rows.Add("APP-9013", "David Miller", "UI/UX & System Design", "2026-11-02", "Payment Received");

            return BuildEntityPage("Applications", dt, new[] { "Application ID", "Applicant Name", "Target Course", "Date", "Status" }, (r) =>
            {
                new EntityDetailsModalForm("Application Details", r["Application ID"].ToString()!, r["Applicant Name"].ToString()!,
                    new[] { ("Status", r["Status"].ToString()!), ("Date", r["Date"].ToString()!), ("Payment", "Verified") },
                    new[] { ("Target Course:", r["Target Course"].ToString()!) },
                    "Reviewer Remarks:", $"Application verified for {r["Target Course"]}.").ShowDialog();
            });
        }

        // --- UNIVERSAL ENTITY PAGE BUILDER ---
        private TabPage BuildEntityPage(string entityName, DataTable dataTable, string[] inputFields, Action<DataRow> onViewModal)
        {
            TabPage page = new TabPage { BackColor = ThemePalette.CanvasBackground };
            SplitContainer split = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Vertical, FixedPanel = FixedPanel.Panel2, SplitterDistance = 720 };

            Panel leftPanel = new Panel { Dock = DockStyle.Fill, BackColor = ThemePalette.CardBackground, Padding = new Padding(15) };

            Panel searchPanel = new Panel { Dock = DockStyle.Top, Height = 45 };
            Label lblIcon = new Label { Text = "🔍", Location = new Point(0, 10), AutoSize = true, ForeColor = ThemePalette.TextMuted };
            TextBox txtSearch = new TextBox { Text = $"Search {entityName}...", ForeColor = ThemePalette.TextMuted, Width = 240, Location = new Point(25, 8), Font = new Font("Segoe UI", 10F) };

            txtSearch.GotFocus += (s, e) => { if (txtSearch.Text.StartsWith("Search")) { txtSearch.Text = ""; txtSearch.ForeColor = ThemePalette.TextPrimary; } };
            txtSearch.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearch.Text)) { txtSearch.Text = $"Search {entityName}..."; txtSearch.ForeColor = ThemePalette.TextMuted; } };
            txtSearch.TextChanged += (s, e) => dataTable.DefaultView.RowFilter = (txtSearch.Text.StartsWith("Search") || string.IsNullOrWhiteSpace(txtSearch.Text)) ? "" : $"[{dataTable.Columns[1].ColumnName}] LIKE '%{txtSearch.Text.Replace("'", "''")}%'";

            Button btnAdd = new Button { Text = "➕ Add New", BackColor = ThemePalette.OceanBlue, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Size = new Size(130, 32), Anchor = AnchorStyles.Top | AnchorStyles.Right, Location = new Point(searchPanel.Width - 135, 6), Font = new Font("Segoe UI Semibold", 8.75F, FontStyle.Bold), Cursor = Cursors.Hand };
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Click += (s, e) => new EntityCrudModalForm($"Create New {entityName}", inputFields).ShowDialog();

            searchPanel.Resize += (s, e) => btnAdd.Location = new Point(searchPanel.Width - 135, 6);
            searchPanel.Controls.AddRange(new Control[] { lblIcon, txtSearch, btnAdd });

            DataGridView grid = ThemePalette.CreateStyledGrid();
            grid.DataSource = dataTable;

            DataGridViewButtonColumn colView = new DataGridViewButtonColumn { Name = "ColView", HeaderText = "View", Text = "👁 View", UseColumnTextForButtonValue = true, FlatStyle = FlatStyle.Flat, Width = 80 };
            DataGridViewButtonColumn colUp = new DataGridViewButtonColumn { Name = "ColUp", HeaderText = "Update", Text = "✏ Update", UseColumnTextForButtonValue = true, FlatStyle = FlatStyle.Flat, Width = 85 };
            DataGridViewButtonColumn colDel = new DataGridViewButtonColumn { Name = "ColDel", HeaderText = "Delete", Text = "🗑 Delete", UseColumnTextForButtonValue = true, FlatStyle = FlatStyle.Flat, Width = 85 };

            grid.Columns.AddRange(new DataGridViewColumn[] { colView, colUp, colDel });

            grid.CellFormatting += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == grid.Columns["ColView"]?.Index) { e.CellStyle.BackColor = ThemePalette.OceanBlue; e.CellStyle.ForeColor = Color.White; }
                    else if (e.ColumnIndex == grid.Columns["ColUp"]?.Index) { e.CellStyle.BackColor = ThemePalette.SteelTeal; e.CellStyle.ForeColor = Color.White; }
                    else if (e.ColumnIndex == grid.Columns["ColDel"]?.Index) { e.CellStyle.BackColor = Color.FromArgb(180, 40, 40); e.CellStyle.ForeColor = Color.White; }
                }
            };

            leftPanel.Controls.AddRange(new Control[] { grid, searchPanel });

            Panel rightPanel = new Panel { Dock = DockStyle.Fill, BackColor = ThemePalette.CardBackground, Padding = new Padding(15) };
            Label formTitle = new Label { Text = $"{entityName} Operations", Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold), ForeColor = ThemePalette.TextPrimary, Dock = DockStyle.Top, Height = 35 };

            FlowLayoutPanel inputsFlow = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true };
            Dictionary<string, TextBox> inputBoxes = new Dictionary<string, TextBox>();

            foreach (string field in inputFields)
            {
                Label lbl = new Label { Text = field, ForeColor = ThemePalette.TextPrimary, Font = new Font("Segoe UI", 9F), Margin = new Padding(0, 6, 0, 2), AutoSize = true };
                TextBox txt = new TextBox { Width = 250, Font = new Font("Segoe UI", 9.5F), BorderStyle = BorderStyle.FixedSingle };
                inputBoxes[field] = txt;
                inputsFlow.Controls.AddRange(new Control[] { lbl, txt });
            }

            grid.CellContentClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
                {
                    DataRow row = ((DataRowView)grid.Rows[e.RowIndex].DataBoundItem).Row;
                    if (e.ColumnIndex == grid.Columns["ColView"].Index) onViewModal(row);
                    else if (e.ColumnIndex == grid.Columns["ColUp"].Index)
                    {
                        foreach (string f in inputFields) if (inputBoxes.ContainsKey(f)) inputBoxes[f].Text = row[f]?.ToString() ?? "";
                        new EntityCrudModalForm($"Update {entityName} Details", inputFields, inputBoxes).ShowDialog();
                    }
                    else if (e.ColumnIndex == grid.Columns["ColDel"]?.Index)
                    {
                        if (MessageBox.Show($"Delete '{row[1]}'?", $"Delete {entityName}", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            dataTable.Rows.Remove(row);
                    }
                }
            };

            grid.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
                {
                    DataGridViewRow row = grid.Rows[e.RowIndex];
                    foreach (string f in inputFields) if (inputBoxes.ContainsKey(f) && grid.Columns.Contains(f)) inputBoxes[f].Text = row.Cells[f]?.Value?.ToString() ?? "";
                }
            };

            FlowLayoutPanel actionsFlow = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 80, FlowDirection = FlowDirection.LeftToRight, Padding = new Padding(0, 10, 0, 0) };
            Button btnSave = CreateBtn("Save", ThemePalette.OceanBlue, (s, e) => new EntityCrudModalForm($"Save New {entityName}", inputFields, inputBoxes).ShowDialog());
            Button btnUpdate = CreateBtn("Update", ThemePalette.SteelTeal, (s, e) => new EntityCrudModalForm($"Update {entityName}", inputFields, inputBoxes).ShowDialog());
            Button btnDelete = CreateBtn("Delete", Color.FromArgb(180, 40, 40), (s, e) => MessageBox.Show("Delete Selected Record", "Delete"));
            Button btnClear = CreateBtn("Clear", ThemePalette.TextMuted, (s, e) => { foreach (var txt in inputBoxes.Values) txt.Text = ""; });

            actionsFlow.Controls.AddRange(new Control[] { btnSave, btnUpdate, btnDelete, btnClear });
            rightPanel.Controls.AddRange(new Control[] { inputsFlow, actionsFlow, formTitle });

            split.Panel1.Controls.Add(leftPanel);
            split.Panel2.Controls.Add(rightPanel);
            page.Controls.Add(split);
            return page;
        }


        private Button CreateBtn(string text, Color bg, EventHandler onClick)
        {
            Button btn = new Button { Text = text, BackColor = bg, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Width = 115, Height = 32, Margin = new Padding(0, 0, 6, 6), Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold), Cursor = Cursors.Hand };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += onClick;
            return btn;
        }
    }
}