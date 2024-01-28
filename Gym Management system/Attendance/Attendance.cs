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
    public partial class Attendance : UserControl
    {
        public Attendance()
        {
            InitializeComponent();
            CheckedInBtn.Click += CheckedInBtn_Click;
            AttSearch_TxtBox.TextChanged += AttSearch_TxtBox_TextChanged;
            ViewThisMonth.Click += ViewThisMonth_Click;
            ViewToDay.Click += ViewToDay_Click;
        }


        private void AttSearch_TxtBox_TextChanged(object sender, EventArgs e) {}
        private void CheckedInBtn_Click(object sender, EventArgs e) {}
        private void ViewThisMonth_Click(object sender, EventArgs e) {}
        private void ViewToDay_Click(object sender, EventArgs e) {}
    }
}
