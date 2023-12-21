

using Gym_Management_system.Database;

namespace Gym_Management_system
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            TableCreater.Init();

            SqlClass sql = new SqlClass();
            sql.CustomerData();
            sql.showtables();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}