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
            plansDashboard1.AddPlan.Click += AddPlan_Click;
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
            string selected = (string)plansDashboard1.PlansComboBox.SelectedItem;

            Dictionary<string, List<object>> plansdata = sql.getPlansDshBdData();
            
            plansDashboard1.PlanNameResult.Text = plansdata[selected][0].ToString();
            plansDashboard1.SignUpFeeResult.Text = plansdata[selected][1].ToString();
            plansDashboard1.PriceResult.Text = plansdata[selected][2].ToString();
            plansDashboard1.PlanTypeResult.Text = plansdata[selected][3].ToString();
            plansDashboard1.TrainerResult.Text = plansdata[selected][4].ToString();
            plansDashboard1.TphoneResult.Text = plansdata[selected][5].ToString();
            //plansDashboard1..Text = plansdata[selected][6].ToString();
            plansDashboard1.S_EtimeResult.Text = plansdata[selected][7].ToString() + plansdata[selected][8].ToString();

        }


        private void AddPlan_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Ready");
        }


    }
}
