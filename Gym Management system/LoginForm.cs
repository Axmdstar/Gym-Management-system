

using Gym_Management_system.Database;

namespace Gym_Management_system
{
    public partial class LoginForm : Form
    {

        public string Username;
        public string Password;

        public LoginForm()
        {
            InitializeComponent();
            TableCreater.Init();

            SqlClass sql = new SqlClass();
            Helper helper = new Helper();
            //sql.Customer();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Authentication user login checking
        //private void UserAuth(string username_from_databse, string password_from_database)
        //{

        //    if (username_from_databse == Username && password_from_database == Password)
        //    {
        //        MessageBox.Show("Successfully");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Incorrect usesrname or password");
        //    }

        //}



        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            string Username = textBoxUserName.Text;



        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string Password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(Password))
            {
                PasswordErrorCheck.Text = "Password is required";
                PasswordErrorCheck.Visible = true;

            }


        }

        private void butto_Click(object sender, EventArgs e)
        {


            Username = textBoxUserName.Text;
            Password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(Username))
            {
                UsernameErrorCheck.Text = "Username is required";
                UsernameErrorCheck.Visible = true;

            }
            else if (string.IsNullOrEmpty(Password))
            {
                PasswordErrorCheck.Text = "Password is required";
                PasswordErrorCheck.Visible = true;

            }


            
            Helper helper = new Helper();
            string q = $@"SELECT username , password FROM users where username = '{Username}' AND password = '{Password}'";
            helper.QueryReader(q, r =>
            {

                if (r.msg.Contains("Error"))
                {
                    Console.WriteLine("Error");
                    MessageBox.Show("Incorrect usesrname or password");

                }
                else
                {
                    Console.WriteLine(r.ReaderData.GetString(0) + r.ReaderData.GetString(1));
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
                
            });

        }
    }
}