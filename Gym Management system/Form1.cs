

namespace Gym_Management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlClass sql = new SqlClass();
            sql.showtable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}