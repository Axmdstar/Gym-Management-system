using Gym_Management_system.Database;
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
    public partial class EditPlanForm : Form
    {
        string planName;
        string ?planType;
        string ?Trainer;
        string timeOut;
        string timeIn;
        float price;
        float SignUpfee;
        Dictionary<string, List<string>> trainers;
        SqlClass sqlClass = new SqlClass();
        List<object> PlanData = new List<object>();

        public EditPlanForm(List<object> planData)
        {
            InitializeComponent();

            TimeIn.Format = DateTimePickerFormat.Custom;
            TimeIn.CustomFormat = "HH:mm ";
            TimeIn.ShowUpDown = true;

            TimeOut.Format = DateTimePickerFormat.Custom;
            TimeOut.CustomFormat = "HH:mm ";
            TimeOut.ShowUpDown = true;

            this.PlanData = planData;

        }



        private void PlanNameTxtBox_TextChange(object sender, EventArgs e) => planName = PlanNameTxtBox.Text;
        private void SignUPFeeTxtBox_TextChange(object sender, EventArgs e) => SignUpfee = Convert.ToSingle(SignUPFeeTxtBox.Text);
        private void PriceTxtBox_TextChange(object sender, EventArgs e) => price = Convert.ToSingle(PriceTxtBox.Text);
        private void TimeOut_ValueChanged(object sender, EventArgs e) => timeOut = TimeOut.Text;
        private void TimeIn_ValueChanged(object sender, EventArgs e) => timeIn = TimeIn.Text;
        private void TrainerList_SelectedIndexChanged(object sender, EventArgs e) => Trainer = TrainerList.SelectedItem.ToString();
        private void PlanTypeList_SelectedIndexChanged(object sender, EventArgs e) => planType = PlanTypeList.SelectedItem.ToString();




        private void AddNewPlan_Click(object sender, EventArgs e)
        {
            string TrainerId = trainers[(string)TrainerList.SelectedItem][0];
            int planid = (int)PlanData[9];
            string query = $@"
                            UPDATE plans 
                            SET plan_name = '{planName}',
	                            plan_type = '{planType}',
	                            price = {price},
	                            staff_id = '{TrainerId}',
	                            signup_fee = {SignUpfee},
                            where id = {planid};
                            UPDATE  Schedule
                            SET time_in = time('{PlanData[7]}'),
                                time_out = time('{PlanData[8]}')
                            where planid = {planid}";
            sqlClass.AddPlantoDb(query);
        }


        private void EditPlanForm_Load(object sender, EventArgs e)
        {

            PlanNameTxtBox.Text = PlanData[0].ToString();
            SignUPFeeTxtBox.Text = PlanData[1].ToString();
            PriceTxtBox.Text = PlanData[2].ToString();
            planType = PlanData[3].ToString();
            TimeIn.Text = PlanData[7].ToString() ?? "00:00";
            TimeOut.Text = PlanData[8].ToString() ?? "00:00";
            PlanTypeList.SelectedItem = PlanData[3].ToString();

            Console.WriteLine(PlanData[9]);
            //Trainers
            trainers = sqlClass.getTrainer();
            foreach (var item in trainers)
            {
                TrainerList.Items.Add(item.Value[1]);
            }

            TrainerList.SelectedItem = PlanData[4].ToString();
        }

    }
}
