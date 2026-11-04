//using System;
//using System.Drawing;
//using System.Windows.Forms;

//namespace TrainingCenterManagementSystem
//{
//    public class AdminCrudModalForm : Form
//    {
//        public AdminCrudModalForm(string menuTitle)
//        {
//            InitializeModalView(menuTitle);
//        }

//        private void InitializeModalView(string menuTitle)
//        {
//            this.Text = menuTitle;
//            this.Size = new Size(460, 500);
//            this.StartPosition = FormStartPosition.CenterParent;
//            this.FormBorderStyle = FormBorderStyle.FixedDialog;
//            this.MaximizeBox = false;
//            this.MinimizeBox = false;
//            this.BackColor = ThemePalette.CanvasBackground;
//            this.Padding = new Padding(20);

//            // Modal Header
//            Panel headerPanel = new Panel { Dock = DockStyle.Top, Height = 45 };
//            Label lblHeader = new Label
//            {
//                Text = menuTitle,
//                Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold),
//                ForeColor = ThemePalette.TextPrimary,
//                Location = new Point(0, 5),
//                AutoSize = true
//            };
//            headerPanel.Controls.Add(lblHeader);

//            // Inputs Container
//            FlowLayoutPanel formFlow = new FlowLayoutPanel
//            {
//                Dock = DockStyle.Fill,
//                FlowDirection = FlowDirection.TopDown,
//                WrapContents = false,
//                AutoScroll = true
//            };

//            CreateModalField(formFlow, "Admin ID Code:", "ADM-00" + new Random().Next(5, 99));
//            CreateModalField(formFlow, "Full Name:", "");
//            CreateModalField(formFlow, "Email Address:", "");
//            CreateModalField(formFlow, "Assign Role:", "Super Admin");
//            CreateModalField(formFlow, "Account Status:", "Active");
//            CreateModalField(formFlow, "Notes / Privileges:", "Full administrative access");

//            // Modal Action Buttons
//            Panel footerPanel = new Panel { Dock = DockStyle.Bottom, Height = 50 };

//            Button btnSubmit = new Button
//            {
//                Text = "Confirm & Save",
//                BackColor = ThemePalette.OceanBlue,
//                ForeColor = Color.White,
//                FlatStyle = FlatStyle.Flat,
//                Size = new Size(130, 36),
//                Location = new Point(140, 10),
//                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold),
//                DialogResult = DialogResult.OK,
//                Cursor = Cursors.Hand
//            };
//            btnSubmit.FlatAppearance.BorderSize = 0;

//            Button btnCancel = new Button
//            {
//                Text = "Cancel",
//                BackColor = ThemePalette.TextMuted,
//                ForeColor = Color.White,
//                FlatStyle = FlatStyle.Flat,
//                Size = new Size(90, 36),
//                Location = new Point(280, 10),
//                Font = new Font("Segoe UI", 9F),
//                DialogResult = DialogResult.Cancel,
//                Cursor = Cursors.Hand
//            };
//            btnCancel.FlatAppearance.BorderSize = 0;

//            footerPanel.Controls.Add(btnSubmit);
//            footerPanel.Controls.Add(btnCancel);

//            this.Controls.Add(formFlow);
//            this.Controls.Add(footerPanel);
//            this.Controls.Add(headerPanel);
//        }

//        private void CreateModalField(FlowLayoutPanel parent, string labelText, string defaultValue)
//        {
//            Label lbl = new Label
//            {
//                Text = labelText,
//                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
//                ForeColor = ThemePalette.TextPrimary,
//                Margin = new Padding(0, 6, 0, 2),
//                AutoSize = true
//            };

//            TextBox txt = new TextBox
//            {
//                Text = defaultValue,
//                Width = 380,
//                Font = new Font("Segoe UI", 10F),
//                BorderStyle = BorderStyle.FixedSingle
//            };

//            parent.Controls.Add(lbl);
//            parent.Controls.Add(txt);
//        }
//    }
//}