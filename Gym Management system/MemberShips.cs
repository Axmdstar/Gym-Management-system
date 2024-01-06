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
    public partial class Memberships : UserControl
    {
        public Memberships()
        {
            InitializeComponent();
            SearchTxtBox.TextChanged += SearchTxtBox_TextChanged;
            NewMemberBtn.Click += NewMemberBtn_Click;
            EditMemberBtn.Click += EditMemberBtn_Click;
            DeleteMemberBtn.Click += DeleteMemberBtn_Click;
            ColumnCombobox.SelectedIndexChanged += ColumnCombobox_SelectedIndexChanged;
            dataGridView1.CellContentClick += SelctedMemberRow;

        }

        public void SelctedMemberRow(object sender, DataGridViewCellEventArgs e) { }
        public void SearchTxtBox_TextChanged(object sender, EventArgs e) { }
        public void NewMemberBtn_Click(object sender, EventArgs e) { }
        public void EditMemberBtn_Click(object sender, EventArgs e) { }
        public void DeleteMemberBtn_Click(object sender, EventArgs e) { }
        public void ColumnCombobox_SelectedIndexChanged(object sender, EventArgs args) { }


    }
}
