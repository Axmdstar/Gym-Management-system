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

        }


        public void PlansComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    //Your code to run on load goes here 
        //    Console.WriteLine("OnLoad");
        //    // Call the base class OnLoad to ensure any delegate event handlers are still callled
        //    base.OnLoad(e);
        //}
    }
}
