using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_system
{
    public partial class Staff : UserControl
    {
        public Staff()
        {
            InitializeComponent();
            SearchTxtBox.TextChanged += SearchTxtBox_TextChanged;
            NewStaffBtn.Click += NewStaffBtn_Click;
            EditStaffBtn.Click += EditStaffBtn_Click;
            DeleteStaffBtn.Click += DeleteStaffBtn_Click;
            ColumnCombobox.SelectedIndexChanged += ColumnCombobox_SelectedIndexChanged;
        }

        public void SearchTxtBox_TextChanged(object sender, EventArgs e) { }
        public void NewStaffBtn_Click(object sender, EventArgs e) { }
        public void EditStaffBtn_Click(object sender, EventArgs e) { }
        public void DeleteStaffBtn_Click(object sender, EventArgs e) { }
        public void ColumnCombobox_SelectedIndexChanged(object sender, EventArgs args) { }
    }
}
