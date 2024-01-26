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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            CheckedInBtn.Click += CheckedInBtn_Click;
            NewMemberBtn.Click += NewMemberBtn_Click;
            AttSearch_TxtBox.TextChanged += AttSearch_TxtBox_TextChanged;
        }

        private void CheckedInBtn_Click(object sender, EventArgs e) { }
        private void NewMemberBtn_Click(object sender, EventArgs e) { }
        private void AttSearch_TxtBox_TextChanged(object sender, EventArgs e) { }
    }
}
