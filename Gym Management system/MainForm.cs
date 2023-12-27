using Microsoft.Win32;
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
        SqlClass sql = new SqlClass();
        public MainForm()
        {
            InitializeComponent();

            plansDashboard1.PlansComboBox.SelectedIndexChanged += PlansComboBox_SelectedIndexChanged;
        }




        // Tabs
        private void iconButton1_Click(object sender, EventArgs e) => dashboard1.BringToFront();
        private void iconButton2_Click(object sender, EventArgs e) => attendance1.BringToFront();
        private void MainForm_Load(object sender, EventArgs e) => dashboard1.BringToFront();
        private void PlansBtn_Click(object sender, EventArgs e) => plansDashboard1.BringToFront();
        



        //Load init data 
        private void plansDashboard1_Load(object sender, EventArgs e)
        {
         
            List<string> list = new List<string>();
            list.AddRange(sql.getPlans());
            foreach (string s in list)
            {
                Console.WriteLine(s);
                plansDashboard1.PlansComboBox.Items.Add(s);
            }

        }


        struct PlansDSBDData
        {
            string PlanName;
            string SignUpFee;
            string Price;
            string PlanType;
            string Trainer;
            string TrainerPhone;
            string Shift;
            string TimeIn;
            string TimeOut;
        }
        private void PlansComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(plansDashboard1.PlansComboBox.SelectedItem + "iten");
            Console.WriteLine(plansDashboard1.PlansComboBox.SelectedValue + "value");

            if (plansDashboard1.PlanTypeResult.Text == "..." && plansDashboard1.PriceResult.Text == "...")
            {

            }


        }
    }
}
