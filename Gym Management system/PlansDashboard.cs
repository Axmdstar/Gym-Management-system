using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//INSERT INTO staff_information
//VALUES('12s', 'lala', 'cam', '2001-2-11','30000000','ff@gmail','Male','new','EU','1231','joack','Mother','Trainer','Evening',500.0)

namespace Gym_Management_system
{
    public partial class PlansDashboard : UserControl
    {

        public PlansDashboard()
        {
            InitializeComponent();
            PlansComboBox.SelectedIndexChanged += PlansComboBox_SelectedIndexChanged;
            AddPlan.Click += AddPlan_Click;
            EditPlan.Click += EditPlan_Click;
            DeletePlan.Click += DeletePlan_Click;
        }


        // Events
        public void PlansComboBox_SelectedIndexChanged(object sender, EventArgs e){}
        public void AddPlan_Click(object sender, EventArgs e){}
        public void DeletePlan_Click(object sender, EventArgs e){}
        public void EditPlan_Click(object sender, EventArgs e){}

    }
}
