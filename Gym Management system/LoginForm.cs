

using Gym_Management_system.Database;

namespace Gym_Management_system
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            TableCreater.Init();

            SqlClass sql = new SqlClass();
            sql.Customer();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}