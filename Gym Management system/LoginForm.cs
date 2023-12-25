

using Gym_Management_system.Database;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gym_Management_system
{
    public partial class LoginForm : Form
    {

        public string Username ;
        public string Password ;

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
        private void UserAuth(string username_from_databse, string password_from_database)
        {
                
            if (username_from_databse == Username && password_from_database == Password)
            {
                MessageBox.Show("Successfully");
            }
            else
            {
                MessageBox.Show("Incorrect usesrname or password");
            }

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


            
                Helper helper = new Helper();
            string q = $@"SELECT username , password FROM users where username = '{Username}'";
            helper.QueryReader(q, r =>
            {

                while (r.ReaderData.Read())
                        {
                    UserAuth(r.ReaderData.GetString(0), r.ReaderData.GetString(1)) ;
                    ////Console.WriteLine(r.ReaderData.GetString(0));
                    //Console.WriteLine(r.ReaderData.GetString(1));
                    //Console.WriteLine(r.ReaderData.GetString(2));
                    //Console.WriteLine(r.ReaderData.GetString(3));
                    //Console.WriteLine(r.ReaderData.GetString(4));
                    ////Console.WriteLine(r.ReaderData.GetString(1));

                }
            });

        }
    }
}