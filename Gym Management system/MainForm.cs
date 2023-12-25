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

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
            //Dashboard db = new Dashboard();
            //db.Show();
            //db.BringToFront();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //Attendance attendance = new Attendance();
            attendance1.BringToFront();
            //attendance1.Hide();

        }

        private void attendance1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
