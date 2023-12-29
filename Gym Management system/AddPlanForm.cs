﻿using Gym_Management_system.Database;
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
    public partial class AddPlanForm : Form
    {
        string planName;
        string planType;
        string Trainer;
        string timeOut;
        string timeIn;
        float price;
        float SignUpfee;
        Dictionary<string, List<string>>? trainers;
        SqlClass sqlClass = new SqlClass();

        public AddPlanForm()
        {

            InitializeComponent();
            //SqlClass sqlClass = new SqlClass();

            TimeIn.Format = DateTimePickerFormat.Custom;
            TimeIn.CustomFormat = "HH:mm ";
            TimeIn.ShowUpDown = true;

            TimeOut.Format = DateTimePickerFormat.Custom;
            TimeOut.CustomFormat = "HH:mm ";
            TimeOut.ShowUpDown = true;
        }



        private void PlanNameTxtBox_TextChange(object sender, EventArgs e) => planName = PlanNameTxtBox.Text;
        private void SignUPFeeTxtBox_TextChange(object sender, EventArgs e) => SignUpfee = Convert.ToSingle(PlanNameTxtBox.Text);
        private void PriceTxtBox_TextChange(object sender, EventArgs e) => price = Convert.ToSingle(PriceTxtBox.Text);
        private void TimeOut_ValueChanged(object sender, EventArgs e) => timeOut = TimeOut.Text;
        private void TimeIn_ValueChanged(object sender, EventArgs e) => timeIn = TimeIn.Text;
        private void TrainerList_SelectedIndexChanged(object sender, EventArgs e) => Trainer = TrainerList.SelectedItem.ToString();
        private void PlanTypeList_SelectedIndexChanged(object sender, EventArgs e) => planType = PlanTypeList.SelectedItem.ToString();
        



        private void AddNewPlan_Click(object sender, EventArgs e)
        {
            string TrainerId = trainers[(string)TrainerList.SelectedItem][0];
            string query = $@"
                INSERT INTO plans (plan_name, signup_fee, price, staff_id, plan_type) VALUES ('{planName}', {SignUpfee}, {price}, '{TrainerId}', '{planType}');
                INSERT INTO Schedule ( plan_id, time_in, time_out) VALUES ((SELECT DISTINCT last_insert_rowid() as id from plans), time('{timeIn}'), time('{timeOut}'));";
            sqlClass.AddPlantoDb(query);
        }


        private void AddPlanForm_Load(object sender, EventArgs e)
        {
            trainers = sqlClass.getTrainer();
            if (trainers.Count != 0)
            {
                foreach (var item in trainers)
                {
                    TrainerList.Items.Add(item.Value[1]);
                }
            }
            else
            {
                TrainerList.Items.Add ("Empty");
            }
        }
    }
}
