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
        Dictionary<string, List<object>>? plansdata = new Dictionary<string, List<object>>();
        SqlClass sql = new SqlClass();
        public MainForm()
        {
            InitializeComponent();

            plansDashboard1.PlansComboBox.SelectedIndexChanged += PlansComboBox_SelectedIndexChanged;
            plansDashboard1.AddPlan.Click += AddPlan_Click;
            plansDashboard1.DeletePlan.Click += DeletePlan_Click;
            plansDashboard1.EditPlan.Click += EditPlan_Click;

            sql.ShowTables();
            //plansdata = sql.getPlansDshBdData() ?? null;
        }




        // Tabs
        private void iconButton1_Click(object sender, EventArgs e) => dashboard1.BringToFront();
        private void iconButton2_Click(object sender, EventArgs e) => attendance1.BringToFront();
        private void MainForm_Load(object sender, EventArgs e) => dashboard1.BringToFront();
        private void PlansBtn_Click(object sender, EventArgs e) => plansDashboard1.BringToFront();



        private void addClosedEvent(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Add is closed");
            plansDashboard1.PlansComboBox.Items.Clear();
            plansdata = sql.getPlansDshBdData() ?? null;
            plansDashboard1_Load(sender, e);
        }

        //Load init data 
        private void plansDashboard1_Load(object sender, EventArgs e)
        {
         
            //List<string> list = new List<string>();

            //List<string>? plansList = new List<string>();
            //plansList = sql.getPlans();
            //if (plansList.Count != 0)
            //{
            //    Console.WriteLine("Planlist Null");
            //    foreach (string s in plansList)
            //    {
            //        plansDashboard1.PlansComboBox.Items.Add(s);
            //    }
            //} else
            //{
            //    Console.WriteLine("IN else");
            //    plansDashboard1.PlansComboBox.Items.Add("No Plans");
            //    plansDashboard1.PlansComboBox.SelectedItem= "No Plans";
            //}
            

        }


        
        private void PlansComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)plansDashboard1.PlansComboBox.SelectedItem;
            if (plansdata.Count != 0)
            {
                plansDashboard1.PlanNameResult.Text = plansdata[selected][0].ToString();
                plansDashboard1.SignUpFeeResult.Text = plansdata[selected][1].ToString();
                plansDashboard1.PriceResult.Text = plansdata[selected][2].ToString();
                plansDashboard1.PlanTypeResult.Text = plansdata[selected][3].ToString();
                plansDashboard1.TrainerResult.Text = plansdata[selected][4].ToString();
                plansDashboard1.TphoneResult.Text = plansdata[selected][5].ToString();
                plansDashboard1.S_EtimeResult.Text = plansdata[selected][7].ToString() + " to " + plansdata[selected][8].ToString();
            }
            

        }


        private void AddPlan_Click(object sender, EventArgs e)
        {
            AddPlanForm addPlanForm = new AddPlanForm();
            addPlanForm.FormClosed += addClosedEvent;
            addPlanForm.ShowDialog();
        }

        

        private void DeletePlan_Click(object sender, EventArgs e)
        {
            string selected = (string)plansDashboard1.PlansComboBox.SelectedItem;
            string DeleteQuery = $@"DELETE from plans where plan_name = '{selected}';";
            sql.DeletePlanFromDb(DeleteQuery);
            plansDashboard1.PlansComboBox.Items.Remove(selected);
        }

        private void EditPlan_Click(object sender, EventArgs e)
        {
            string selected = (string)plansDashboard1.PlansComboBox.SelectedItem;
            //Console.WriteLine(plansdata[selected][1]);

            if (selected != null)
            {
                EditPlanForm editPlanForm = new EditPlanForm(plansdata[selected]);
                editPlanForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select Plan");
            }

        }
    }
}
