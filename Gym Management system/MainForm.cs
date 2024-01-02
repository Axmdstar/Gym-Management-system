using System.ComponentModel;
using MaterialSkin2DotNet.Animations;
using MaterialSkin2DotNet;
using System.Data;
using MaterialSkin2DotNet.Controls;

namespace Gym_Management_system
{

    public partial class MainForm : Form
    {
        Dictionary<string, List<object>>? plansdata = new Dictionary<string, List<object>>();
        SqlClass sql = new SqlClass();

        string Username;
        string UserType;

        string SearchFilter = "firstName";

        public MainForm(string Username, string UserType)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.LightGreen900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightGreen400, TextShade.BLACK);

            //Plans Events
            plansDashboard1.PlansComboBox.SelectedIndexChanged += PlansComboBox_SelectedIndexChanged;
            plansDashboard1.AddPlan.Click += AddPlan_Click;
            plansDashboard1.DeletePlan.Click += DeletePlan_Click;
            plansDashboard1.EditPlan.Click += EditPlan_Click;

            //Staff Events
            
            staff1.SearchTxtBox.TextChanged += SearchTxtBox_TextChanged;
            staff1.ColumnCombobox.SelectedIndexChanged += ColumnCombobox_SelectedIndexChanged;
            //staff1.NewStaffBtn.Click += NewStaffBtn_Click;
            //staff1.EditStaffBtn.Click += Ed itStaffBtn_Click;
            //staff1.DeleteStaffBtn.Click += DeleteStaffBtn_Click;

            this.Username = Username;
            this.UserType = UserType;
            plansdata = sql.getPlansDshBdData() ?? null;
            UserNameLbl.Text = Username;

            if (UserType == "SuperAdmin")
            {

            }
            else
            {
                StaffBtn.Enabled = false;
                StaffBtn.BackColor = Color.FromArgb(51, 60, 67);
            }

        }




        // Tabs
        private void iconButton1_Click(object sender, EventArgs e) => dashboard1.BringToFront();
        private void iconButton2_Click(object sender, EventArgs e) => attendance1.BringToFront();
        private void MainForm_Load(object sender, EventArgs e) => dashboard1.BringToFront();
        private void PlansBtn_Click(object sender, EventArgs e) => plansDashboard1.BringToFront();
        private void StaffBtn_Click(object sender, EventArgs e) => staff1.BringToFront();




        // Form CloseEvents
        private void addClosedEvent(object sender, FormClosedEventArgs e)
        {
            plansDashboard1.PlansComboBox.Items.Clear();
            plansdata = sql.getPlansDshBdData() ?? null;
            plansDashboard1_Load(sender, e);
        }


        //Load init data 
        private void plansDashboard1_Load(object sender, EventArgs e)
        {
            List<string>? plansList = new List<string>();
            plansList = sql.getPlans();
            if (plansList.Count != 0)
            {
                Console.WriteLine("Planlist not Null");
                foreach (string s in plansList)
                {
                    plansDashboard1.PlansComboBox.Items.Add(s);
                }
            }
            else
            {
                Console.WriteLine("No Plans");
                plansDashboard1.PlansComboBox.Items.Add("No Plans");
                plansDashboard1.PlansComboBox.SelectedItem = "No Plans";
            }

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
                editPlanForm.FormClosed += addClosedEvent;

                editPlanForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Select Plan");
            }

        }


        private void staff1_Load(object sender, EventArgs e)
        {
            
            string query = @"SELECT * FROM staff_information";
            staff1.dataGridView1.DataSource = sql.GetStaffData(query);

        }




        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            string SrhTxt = staff1.SearchTxtBox.Text;
            string query = $@"Select * from staff_information where {SearchFilter} like '{SrhTxt}%'";
            //staff1.dataGridView1.DataSource = null;
            //staff1.dataGridView1.Rows.Clear();
            staff1.dataGridView1.DataSource = sql.GetStaffData(query);
        }

        private void ColumnCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFilter = staff1.ColumnCombobox.SelectedItem.ToString();
            Console.WriteLine(SearchFilter);
        }
    }
}
