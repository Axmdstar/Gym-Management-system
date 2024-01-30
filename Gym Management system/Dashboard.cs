using Gym_Management_system;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_system
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            DshCheckedInBtn.Click += dshCheckedInBtn_Click;
            NewMemberBtn.Click += NewMemberBtn_Click;
            DshSearch_TxtBox.TextChanged += dshSearch_TxtBox_TextChanged;
            this.Load += Dashboard_Load;
        }

        private void dshCheckedInBtn_Click(object sender, EventArgs e) { }
        private void NewMemberBtn_Click(object sender, EventArgs e) { }
        private void dshSearch_TxtBox_TextChanged(object sender, EventArgs e) { }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
        private void Dashboard_Load(object sender, EventArgs e) { }
    }
}


//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Windows.Forms;

//namespace System_Weapon
//{
//    public partial class IndividualReport : Form
//    {
//        const string connectionString = "Data Source=OMAR_MOHAMMED\\SQLEXPRESS; Initial Catalog=WEAPONDB;Integrated Security=True;";

//        // Add a variable to store the selected display option
//        private string selectedDisplayOption = "OwnerID";
//        private string selectedDisplayOptions = "OwnerName";


//        public IndividualReport()
//        {
//            InitializeComponent();
//            InitializeComboBoxes();
//        }

//        private void InitializeComboBoxes()
//        {
//            comboBoxIDName.Items.Add("ID");
//            comboBoxIDName.Items.Add("Name");
//            comboBoxIDName.SelectedIndex = 0;

//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();
//                SqlCommand command = new SqlCommand("SELECT OwnerID, OwnerName FROM Owners", connection);
//                SqlDataReader reader = command.ExecuteReader();

//                while (reader.Read())
//                {
//                    comboBoxDisplays.Items.Add(reader[selectedDisplayOption].ToString());
//                    comboBoxDisplays.Items.Add(reader[selectedDisplayOptions].ToString());

//                }

//                reader.Close();
//            }
//        }

//        private void btnSearch_Click(object sender, EventArgs e)
//        {
//            // Fetch data from the database based on the selected option and display it in the DataGridView
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();
//                string query = $"SELECT * FROM Owners WHERE {selectedDisplayOption}, {selectedDisplayOptions} = '{comboBoxDisplays.SelectedItem}'";
//                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
//                DataTable dataTable = new DataTable();
//                adapter.Fill(dataTable);
//                dataGridView1.DataSource = dataTable;
//            }
//        }

//        private void comboBoxIDName_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            selectedDisplayOption = comboBoxIDName.SelectedItem.ToString();
//            selectedDisplayOptions = comboBoxIDName.SelectedItem.ToString();
//        }


//        private void btnLogout_Click_1(object sender, EventArgs e)
//        {
//            DialogResult check = MessageBox.Show("Are you sure you want to Log Out of the System?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

//            if (check == DialogResult.Yes)
//            {
//                MainForm Indi = new MainForm();
//                Indi.Show();
//                this.Hide();
//            }
//        }

//    }
//}
