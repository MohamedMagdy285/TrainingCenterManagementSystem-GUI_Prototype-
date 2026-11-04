using System.Drawing;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    partial class EntityCrudModalForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel = null!;
        private Label lblHeader = null!;

        private FlowLayoutPanel formFlow = null!;

        // Sample Designer Controls (للمعاينة والتعديل من الـ Designer)
        private Label lblSampleField1 = null!;
        private TextBox txtSampleField1 = null!;
        private Label lblSampleField2 = null!;
        private TextBox txtSampleField2 = null!;
        private Label lblSampleField3 = null!;
        private TextBox txtSampleField3 = null!;

        private Panel footerPanel = null!;
        private Button btnSubmit = null!;
        private Button btnCancel = null!;

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
            headerPanel = new Panel();
            lblHeader = new Label();
            formFlow = new FlowLayoutPanel();
            lblSampleField1 = new Label();
            txtSampleField1 = new TextBox();
            lblSampleField2 = new Label();
            txtSampleField2 = new TextBox();
            lblSampleField3 = new Label();
            txtSampleField3 = new TextBox();
            footerPanel = new Panel();
            btnSubmit = new Button();
            btnCancel = new Button();
            headerPanel.SuspendLayout();
            formFlow.SuspendLayout();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Transparent;
            headerPanel.Controls.Add(lblHeader);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(20, 20);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(402, 40);
            headerPanel.TabIndex = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(30, 41, 59);
            lblHeader.Location = new Point(0, 5);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(242, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Manage Record Details";
            // 
            // formFlow
            // 
            formFlow.AutoScroll = true;
            formFlow.BackColor = Color.Transparent;
            formFlow.Controls.Add(lblSampleField1);
            formFlow.Controls.Add(txtSampleField1);
            formFlow.Controls.Add(lblSampleField2);
            formFlow.Controls.Add(txtSampleField2);
            formFlow.Controls.Add(lblSampleField3);
            formFlow.Controls.Add(txtSampleField3);
            formFlow.Dock = DockStyle.Fill;
            formFlow.FlowDirection = FlowDirection.TopDown;
            formFlow.Location = new Point(20, 60);
            formFlow.Name = "formFlow";
            formFlow.Size = new Size(402, 183);
            formFlow.TabIndex = 0;
            formFlow.WrapContents = false;
            // 
            // lblSampleField1
            // 
            lblSampleField1.AutoSize = true;
            lblSampleField1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSampleField1.ForeColor = Color.FromArgb(30, 41, 59);
            lblSampleField1.Location = new Point(0, 6);
            lblSampleField1.Margin = new Padding(0, 6, 0, 2);
            lblSampleField1.Name = "lblSampleField1";
            lblSampleField1.Size = new Size(108, 20);
            lblSampleField1.TabIndex = 0;
            lblSampleField1.Text = "Record Name:";
            // 
            // txtSampleField1
            // 
            txtSampleField1.BorderStyle = BorderStyle.FixedSingle;
            txtSampleField1.Font = new Font("Segoe UI", 10F);
            txtSampleField1.Location = new Point(3, 31);
            txtSampleField1.Name = "txtSampleField1";
            txtSampleField1.Size = new Size(380, 30);
            txtSampleField1.TabIndex = 1;
            // 
            // lblSampleField2
            // 
            lblSampleField2.AutoSize = true;
            lblSampleField2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSampleField2.ForeColor = Color.FromArgb(30, 41, 59);
            lblSampleField2.Location = new Point(0, 70);
            lblSampleField2.Margin = new Padding(0, 6, 0, 2);
            lblSampleField2.Name = "lblSampleField2";
            lblSampleField2.Size = new Size(127, 20);
            lblSampleField2.TabIndex = 2;
            lblSampleField2.Text = "Category / Code:";
            // 
            // txtSampleField2
            // 
            txtSampleField2.BorderStyle = BorderStyle.FixedSingle;
            txtSampleField2.Font = new Font("Segoe UI", 10F);
            txtSampleField2.Location = new Point(3, 95);
            txtSampleField2.Name = "txtSampleField2";
            txtSampleField2.Size = new Size(380, 30);
            txtSampleField2.TabIndex = 3;
            // 
            // lblSampleField3
            // 
            lblSampleField3.AutoSize = true;
            lblSampleField3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSampleField3.ForeColor = Color.FromArgb(30, 41, 59);
            lblSampleField3.Location = new Point(0, 134);
            lblSampleField3.Margin = new Padding(0, 6, 0, 2);
            lblSampleField3.Name = "lblSampleField3";
            lblSampleField3.Size = new Size(93, 20);
            lblSampleField3.TabIndex = 4;
            lblSampleField3.Text = "Description:";
            // 
            // txtSampleField3
            // 
            txtSampleField3.BorderStyle = BorderStyle.FixedSingle;
            txtSampleField3.Font = new Font("Segoe UI", 10F);
            txtSampleField3.Location = new Point(3, 159);
            txtSampleField3.Name = "txtSampleField3";
            txtSampleField3.Size = new Size(380, 30);
            txtSampleField3.TabIndex = 5;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.Transparent;
            footerPanel.Controls.Add(btnSubmit);
            footerPanel.Controls.Add(btnCancel);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(20, 243);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(402, 50);
            footerPanel.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(14, 116, 144);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.DialogResult = DialogResult.OK;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(130, 10);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(130, 36);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Save Changes";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(100, 116, 139);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(270, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // EntityCrudModalForm
            // 
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(442, 313);
            Controls.Add(formFlow);
            Controls.Add(footerPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EntityCrudModalForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Record";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            formFlow.ResumeLayout(false);
            formFlow.PerformLayout();
            footerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}