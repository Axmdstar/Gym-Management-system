

using Gym_Management_system.Database;

namespace Gym_Management_system
{
    public partial class LoginForm : Form
    {

        public string Username;
        public string Password;
        Helper helper = new Helper();
        SqlClass sql = new SqlClass();



        public LoginForm()
        {
            InitializeComponent();
            TableCreater.Init();

            //sql.ShowTables();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        



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



            
            string q = $@"SELECT username , password FROM users where username = '{Username}' AND password = '{Password}'";
            helper.QueryReader(q, r =>
            {

                if (r.msg.Contains("Error"))
                {
                    //Username io passwordka ii shaqeen waayay sidAAD ayaan sidan u sameeyay kaliy labada sadar ku xigto comment ka qaad inta ka hooseesana ka delete
                    //Console.WriteLine("Error");
                    //MessageBox.Show("Incorrect usesrname or password");
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();

                }
                else
                {
                    Console.WriteLine(r.ReaderData.GetString(0) + r.ReaderData.GetString(1));

                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    
                }

            });

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