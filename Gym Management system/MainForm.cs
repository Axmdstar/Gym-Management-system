using System.ComponentModel;
using MaterialSkin2DotNet.Animations;
using MaterialSkin2DotNet;
using System.Data;
using MaterialSkin2DotNet.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gym_Management_system
{

    public partial class MainForm : Form
    {
        //fields
        Dictionary<string, List<object>>?  plansdata  = new Dictionary<string, List<object>>();
        SqlClass sql = new SqlClass();

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


        //Switch btw Forms
        public void Switcher(object Form)
        {
            if (this.DisplayPanel.Controls.Count > 0)
            {
                this.DisplayPanel.Controls.RemoveAt(0);
            }

            Form Wform = Form as Form;
            Wform.TopLevel = false;
            Wform.Dock = DockStyle.Fill;
            this.DisplayPanel.Controls.Add(Wform);
            this.DisplayPanel.Tag = Wform;
            Wform.Show();
        }


        //############################################################################
        //Add load Functions to their associted tab
        //Duplicate errors
        //############################################################################


        // Tabs

        private void Dashboard_Click(object sender, EventArgs e) => Switcher(new DashboardForm());
        private void iconButton2_Click(object sender, EventArgs e) => Switcher(new Attendance());
        private void MainForm_Load(object sender, EventArgs e) => Switcher(new DashboardForm());
        private void PlansBtn_Click(object sender, EventArgs e) => Switcher(new PlansDashboard( ref plansdata));
        private void StaffBtn_Click(object sender, EventArgs e) => Switcher(new Staff());
        private void MemberShips_Click(object sender, EventArgs e) => Switcher(new Memberships(plansdata));


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

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
