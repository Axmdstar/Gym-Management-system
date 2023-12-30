

using Gym_Management_system.Database;

namespace Gym_Management_system
{
    public partial class LoginForm : Form
    {

        public string Username;
        public string Password;
        public string UserType;

        Helper helper = new Helper();
        SqlClass sql = new SqlClass();
        public bool Auth ;

        public LoginForm()
        {
            InitializeComponent();
            TableCreater.Init();

        }


        public void UserAuthentication(string username, string password)
        {
            string q = $@"select username, password, staff_type From users as usr
                          INNER JOIN staff_information as stf on usr.staff_id = stf.id
                          where username = '{username}' and password = '{password}';";
            helper.QueryReader(q, r =>
            {
                if (r.msg.Contains("Error"))
                {
                    Console.WriteLine(r.msg);

                    MessageBox.Show("Incorrect usesrname or password");
                }
                else
                {
                    r.ReaderData.Read();
                    UserType = r.ReaderData.GetString(2);
                    Auth = true;
                    this.Close(); 
                }
            });

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
            } else
            {
                UserAuthentication(Username, Password);
            }
            
            //string q = $@"SELECT username , password FROM users where username = '{Username}' AND password = '{Password}'";
            //helper.QueryReader(q, r =>
            //{
            //    if (r.msg.Contains("Error"))
            //    {
            //        Console.WriteLine(r.msg);

            //        MessageBox.Show("Incorrect usesrname or password");
            //    }
            //    else
            //    {
            //        r.ReaderData.Read();
            //        Console.WriteLine(r.ReaderData.GetString(0) + r.ReaderData.GetString(1));

                    
            //        MainForm mainForm = new MainForm();
            //        //this.
            //        mainForm.ShowDialog();
            //    }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '*')
            {
                textBoxPassword.PasswordChar = (char)0;
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }

        }
    }
}