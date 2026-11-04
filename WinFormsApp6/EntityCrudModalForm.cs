using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrainingCenterManagementSystem
{
    public partial class EntityCrudModalForm : Form
    {
        public EntityCrudModalForm()
        {
            InitializeComponent();
        }

        public EntityCrudModalForm(string title, string[] fields, Dictionary<string, TextBox>? currentValues = null) : this()
        {
            this.Text = title;
            this.lblHeader.Text = title;
        }
    }
}