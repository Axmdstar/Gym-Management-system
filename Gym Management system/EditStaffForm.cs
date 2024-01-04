using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gym_Management_system
{
    public partial class EditStaff : Form
    {
        string? FirstName;
        string? LastName;
        string? Dob;
        string? Tell;
        string? Email;
        string? Sex;
        string? City;
        string? Village;
        string? Em_Contact;
        string? Em_Tell;
        string? Em_Relation;
        string? Shift;
        string? Staff_type;
        float Salary;

        int StaffId;
        

        SqlClass sqlclass = new SqlClass();

        public EditStaff(DataGridViewRow row)
        {
            //(int)row.Cells[0].Value
            InitializeComponent();

            StaffId = (int)row.Cells[0].Value;
            FirstNameTextBox.Text = row.Cells[1].Value.ToString();
            LastNameTextBox.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Text = row.Cells[3].Value.ToString();
            TellTxtBox.Text = row.Cells[4].Value.ToString();
            EmailTextBox.Text = row.Cells[5].Value.ToString();
            SexComboBox.SelectedItem = row.Cells[6].Value.ToString();
            CityTextBox.Text = row.Cells[7].Value.ToString();
            VillageTextBox.Text = row.Cells[8].Value.ToString();
            ContactTellTextBox.Text = row.Cells[9].Value.ToString();
            ContactTextBox.Text = row.Cells[10].Value.ToString();   
            RelationComboBox.SelectedItem = row.Cells[11].Value.ToString();
            ShiftComboBox.SelectedItem = row.Cells[12].Value.ToString();
            StaffTypeComboBox.SelectedItem = row.Cells[13].Value.ToString();
            SalaryTextBox.Text = row.Cells[14].Value.ToString();

        }



        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FirstName = FirstNameTextBox.Text;
        }
        private void LastNameText_TextChanged(object sender, EventArgs e)
        {
            LastName = LastNameTextBox.Text;
        }
        private void TellTxtBox_TextChanged(object sender, EventArgs e)
        {
            Tell = TellTxtBox.Text;
        }
        private void EmailTextBox_TextChanged(object sender, EventArgs args)
        {
            Email = EmailTextBox.Text;
        }

        private void CityText_TextChanged(object sender, EventArgs args)
        {
            City = CityTextBox.Text;
        }

        private void SalaryTextBox_TextChanged(object sender, EventArgs args)
        {
            Salary = Convert.ToSingle(SalaryTextBox.Text);
        }
        private void dateTimePicker1_TextChanged(object sender, EventArgs args)
        {
            Dob = dateTimePicker1.Text;
        }
        private void SexComboBox_TextChanged(object sender, EventArgs args)
        {
            Sex = SexComboBox.SelectedItem.ToString();
        }
        private void VillageTextBox_TextChanged(object sender, EventArgs args)
        {
            Village = VillageTextBox.Text;
        }
        private void ContactTextBox_TextChanged(object sender, EventArgs args)
        {
            Em_Contact = ContactTextBox.Text;
        }
        private void RelationComboBox_TextChanged(object sender, EventArgs args)
        {
            Em_Relation = RelationComboBox.SelectedItem.ToString();
        }
        private void ContactTellTextBox_TextChanged(object sender, EventArgs args)
        {
            Em_Tell = ContactTellTextBox.Text;
        }
        private void StaffTypeComboBox_TextChanged(object sender, EventArgs args)
        {
            Staff_type = StaffTypeComboBox.SelectedItem.ToString();
        }
        private void ShiftComboBox_TextChanged(object sender, EventArgs args)
        {
            Shift = ShiftComboBox.SelectedItem.ToString();
        }

        private void EditStaffBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Dob);
            Console.WriteLine(Tell);
            Console.WriteLine(Email);
            Console.WriteLine(Sex);
            Console.WriteLine(City);
            Console.WriteLine(Village);
            Console.WriteLine(Em_Contact);
            Console.WriteLine(Em_Tell);
            Console.WriteLine(Em_Relation);
            Console.WriteLine(Shift);
            Console.WriteLine(Staff_type);
            Console.WriteLine(Salary);

            string query = $@"UPDATE  staff_information
                            SET firstname = '{FirstName}',
                                lastname = '{LastName}',
                                dob = '{Dob}',
                                tell = '{Tell}',
                                email = '{Email}',
                                sex = '{Sex}',
                                city = '{City}',
                                village = '{Village}',
                                emergency_contact = '{Em_Tell}',
                                emergency_name = '{Em_Contact}',
                                emergency_relation = '{Em_Relation}',
                                shift = '{Shift}',
                                staff_type = '{Staff_type}',
                                salary = {Salary}
	                            WHERE id = {StaffId};";

            sqlclass.EditStaffToDb(query);
        }

    }
}
