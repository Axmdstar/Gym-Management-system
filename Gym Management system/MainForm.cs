using System.ComponentModel;
using MaterialSkin2DotNet.Animations;
using MaterialSkin2DotNet;
using System.Data;
using MaterialSkin2DotNet.Controls;

namespace Gym_Management_system
{

    public partial class MainForm : Form
    {
        //fields
        Dictionary<string, List<object>>? plansdata = new Dictionary<string, List<object>>();
        SqlClass sql = new SqlClass();
        List<string>? plansList = new List<string>();


        int StaffCellID;
        int MemberCellID;
        int rowindex;


        //userInfo
        string Username;
        string UserType;

        //default search filter
        string SearchFilter = "firstName";

        public MainForm(string Username, string UserType)
        {
            InitializeComponent();
            timer1.Start();

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
            staff1.dataGridView1.CellContentClick += SelctedStaffRow;
            staff1.SearchTxtBox.TextChanged += SearchTxtBox_TextChanged;
            staff1.ColumnCombobox.SelectedIndexChanged += StaffColumnCombobox_SelectedIndexChanged;
            staff1.NewStaffBtn.Click += NewStaffBtn_Click;
            staff1.EditStaffBtn.Click += EditStaffBtn_Click;
            staff1.DeleteStaffBtn.Click += DeleteStaffBtn_Click;

            //Member Events
            memberships1.dataGridView1.CellContentClick += SelctedMemberRow;
            memberships1.NewMemberBtn.Click += NewMemberBtn_Click;
            memberships1.EditMemberBtn.Click += EditMemberBtn_Click;
            memberships1.DeleteMemberBtn.Click += DeleteMemberBtn_Click;
            memberships1.SearchTxtBox.TextChanged += SearchTxtBox_Member;
            memberships1.ColumnCombobox.SelectedIndexChanged += MemberColumnCombobox_SelectedIndexChanged;

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
        private void MemberShips_Click(object sender, EventArgs e) => memberships1.BringToFront();



        // Form CloseEvents
        private void PlansClosedEvent(object sender, FormClosedEventArgs e)
        {
            plansDashboard1.PlansComboBox.Items.Clear();
            plansdata = sql.getPlansDshBdData() ?? null;
            plansDashboard1_Load(sender, e);
        }
        private void StaffClosedEvent(object sender, FormClosedEventArgs e)
        {
            staff1_Load(sender, e);
        }
        private void MemberClosedEvent(object sender, FormClosedEventArgs e)
        { 
            memberships1_Load(sender, e);
        }




        //Load init data 
        private void plansDashboard1_Load(object sender, EventArgs e)
        {
            plansList = sql.getPlans();
            if (plansList.Count != 0)
            {
                foreach (string s in plansList)
                {
                    plansDashboard1.PlansComboBox.Items.Add(s);
                }
            }
            else
            {
                plansDashboard1.PlansComboBox.Items.Add("No Plans");
                plansDashboard1.PlansComboBox.SelectedItem = "No Plans";
            }
        }

        private void staff1_Load(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM staff_information";
            staff1.dataGridView1.DataSource = sql.GetStaffData(query);
        }
        private void memberships1_Load(object sender, EventArgs e)
        {
            string query = @"select * from Customer_info";
            memberships1.dataGridView1.DataSource = sql.GetMembersData(query);
        }



        //Buttons 
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


        // Delete btn
        private void DeletePlan_Click(object sender, EventArgs e)
        {
            string selected = (string)plansDashboard1.PlansComboBox.SelectedItem;
            string DeleteQuery = $@"DELETE from plans where plan_name = '{selected}';";
            sql.ExcuteQuery(DeleteQuery);
            plansDashboard1.PlansComboBox.Items.Remove(selected);
        }
        private void DeleteStaffBtn_Click(object sender, EventArgs e)
        {
            string query = $@"DELETE from staff_information where id = {StaffCellID};";

            sql.ExcuteQuery(query);
            staff1_Load(sender, e);
        }
        private void DeleteMemberBtn_Click(object sender, EventArgs e)
        {
            string query = $@"DELETE from Customer_info where id = {MemberCellID};";
            sql.ExcuteQuery(query);
            memberships1_Load(sender, e);
        }



        // Edit Btn
        private void EditPlan_Click(object sender, EventArgs e)
        {
            string selected = (string)plansDashboard1.PlansComboBox.SelectedItem;
            //Console.WriteLine(plansdata[selected][1]);
            if (selected != null)
            {
                EditPlanForm editPlanForm = new EditPlanForm(plansdata[selected]);
                editPlanForm.FormClosed += PlansClosedEvent;
                editPlanForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select Plan");
            }
        }
        private void EditStaffBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = staff1.dataGridView1.Rows[rowindex];
            EditStaff editStaffform = new EditStaff(row);
            editStaffform.FormClosed += StaffClosedEvent;
            editStaffform.ShowDialog();
        }

        private void EditMemberBtn_Click(object obj, EventArgs e)
        {
            DataGridViewRow row = memberships1.dataGridView1.Rows[rowindex];
            EditMember editMemberform = new EditMember(row, plansdata);
            editMemberform.ShowDialog();

        }




        //Search Events
        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            string SrhTxt = staff1.SearchTxtBox.Text;
            string query = $@"Select * from staff_information where {SearchFilter} like '{SrhTxt}%'";
            staff1.dataGridView1.DataSource = sql.GetStaffData(query);
        }
        private void StaffColumnCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFilter = staff1.ColumnCombobox.SelectedItem.ToString();
        }

        private void SearchTxtBox_Member(object sender, EventArgs e)
        {
            string SrhTxt = memberships1.SearchTxtBox.Text;
            string query = $@"Select * from Customer_info where {SearchFilter} like '{SrhTxt}%'";
            memberships1.dataGridView1.DataSource = sql.GetMembersData(query);
        }
        private void MemberColumnCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFilter = memberships1.ColumnCombobox.SelectedItem.ToString();
        }


        //AddBtn
        public void NewStaffBtn_Click(object sender, EventArgs e)
        {
            AddStaff addstaff = new AddStaff();
            addstaff.FormClosed += StaffClosedEvent;
            addstaff.ShowDialog();
        }
        private void AddPlan_Click(object sender, EventArgs e)
        {
            AddPlanForm addPlanForm = new AddPlanForm();
            addPlanForm.FormClosed += PlansClosedEvent;
            addPlanForm.ShowDialog();
        }
        private void NewMemberBtn_Click(object sender, EventArgs args){
            AddMember addmember = new AddMember(plansdata);
            //addmember.FormClosed += 
            addmember.ShowDialog();
        }



        //GridEvents
        private void SelctedStaffRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                rowindex = e.RowIndex;
                DataGridViewRow row = staff1.dataGridView1.Rows[e.RowIndex];
                StaffCellID = (int)row.Cells[0].Value;
            }
        }

        private void SelctedMemberRow(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= -1)
            {
                rowindex = e.RowIndex;
                DataGridViewRow row = memberships1.dataGridView1.Rows[e.RowIndex];
                MemberCellID = (int)row.Cells[0].Value;
            }
        }



        //Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            Timerlabel.Text = DateTime.Now.ToString("hh:mm tt");
        }


        //Close Window
        private void iconButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
