using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics;
using System.Data.SqlClient;
using Gym_Management_system.Database;
using static Gym_Management_system.Database.Helper;

public class SqlClass
{
    Helper helper = new Helper();

    public string ConnetionStr { get { return helper.ConnectionString; } }

    


    public void ShowTables()
    {
     //     string path = @"C:\Users\Farah\source\repos\Gym-Management-system\Gym Management system\Database\Gym.db";
     //string ConnectionString = @$"Data Source={path};Version=3;";
    string query = @"SELECT id, firstname FROM staff_information where staff_type = 'Trainer'";

        

        helper.QueryReader(query, r =>
        {
            Console.WriteLine(r.ReaderData.FieldCount);
            while (r.ReaderData.Read())
            {
                Console.WriteLine(r.ReaderData.GetString(1));
            }
        });
    }


    


    

    public Dictionary<string, List<object>>? getPlansDshBdData()
    {
        string query = @"SELECT p.plan_name, p.signup_fee, p.price, p.plan_type, si.firstname, si.tell, si.shift,strftime('%H:%M',                                sch.time_in), strftime('%H:%M',sch.time_out), p.id from plans as p
                                LEFT JOIN staff_information as si on p.staff_id = si.id
                                LEFT JOIN schedule as sch on sch.plan_id = p.id";

        Dictionary<string, List<object>> Dict = new Dictionary<string, List<object>>();

        int count = 0;
        helper.QueryReader(query, r =>
        {
            if (r.ReaderData.HasRows)
            {

            while (r.ReaderData.Read())
            {
                // Use the GetValue method and handle null values
                string planName = r.ReaderData.IsDBNull(0) ? "NULL" : r.ReaderData.GetString(0);
                float signupFee = r.ReaderData.IsDBNull(1) ? 0 : r.ReaderData.GetFloat(1);
                float price = r.ReaderData.IsDBNull(2) ? 0 : r.ReaderData.GetFloat(2);
                string planType = r.ReaderData.IsDBNull(3) ? "NULL" : r.ReaderData.GetString(3);
                string firstname = r.ReaderData.IsDBNull(4) ? "NULL" : r.ReaderData.GetString(4);
                string tell = r.ReaderData.IsDBNull(5) ? "NULL" : r.ReaderData.GetString(5);
                string shift = r.ReaderData.IsDBNull(6) ? "NULL" : r.ReaderData.GetString(6);
                string timeIn = r.ReaderData.IsDBNull(7) ? "NULL" : r.ReaderData.GetString(7);
                string timeOut = r.ReaderData.IsDBNull(8) ? "NULL" : r.ReaderData.GetString(8);
                int planId = r.ReaderData.IsDBNull(9) ? 0 : r.ReaderData.GetInt32(9);

                List<object> list = new List<object>
                {
                    planName,
                    signupFee,
                    price,
                    planType,
                    firstname,
                    tell,
                    shift,
                    timeIn,
                    timeOut,
                    planId
                };

                Dict.Add(planName, list);
                count++;
            }
            }

        });

        return Dict ?? null;

    }



    public List<string> getPlans()
    {
        string query = @"select plan_name from plans";
        List<string> list = new List<string>();
        helper.QueryReader(query, r =>
        {
            //if (!r.ReaderData.Read() )
            //{
                while (r.ReaderData.Read())
                {
                    list.Add(r.ReaderData.GetString(0));
                }
            //}
        });
        return list;
    }

    public Dictionary<string, List<object>> getTrainer()
    {
        string query = @"SELECT id, firstname FROM staff_information where staff_type = 'Trainer';";

        Dictionary<string, List<object>> DictTrainer = new Dictionary<string, List<object>>();

        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                int staffId = r.ReaderData.GetInt32(0);
                string staffName = r.ReaderData.GetString(1);

                List<object> list = new List<object>
                    {
                        staffId, staffName
                    };
                DictTrainer.Add(staffName, list);
            }
        });

        return DictTrainer;
    }


    public void AddPlantoDb(string query)
    {
        helper.QueryWriter(query, r =>
        {
            Console.WriteLine(r.msg); 
        });
    }

    public void DeletePlanFromDb(string query)
    {
        helper.QueryWriter(query, r =>
        {
            Console.WriteLine(r.msg);
        });
    }

    
    public List<Staffs> GetStaffData()
    {
        List<Staffs> StaffList = new List<Staffs>();
        string query = @"SELECT * FROM staff_information";
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {

                int id = (int)r.ReaderData.GetString(0);
                string FirstName = r.ReaderData.GetString(1);
                string LastName = r.ReaderData.GetString(2);
                string DoB = r.ReaderData.GetString(3);
                string Tell = r.ReaderData.GetString(4);
                string Email = r.ReaderData.GetString(5);
                string Sex = r.ReaderData.GetString(6);
                string City = r.ReaderData.GetString(7);
                string Village = r.ReaderData.GetString(8);
                string Em_Contact = r.ReaderData.GetString(9);
                string Emm_Name = r.ReaderData.GetString(10);
                string Emm_R = r.ReaderData.GetString(11);
                string Shift = r.ReaderData.GetString(12);
                string StaffType = r.ReaderData.GetString(13);
                //float Salary = Convert.ToSingle(r.ReaderData.GetString(14));






                //Staffs staffs = new Staffs(
                //id,
                //FirstName,
                //LastName,
                //DoB,
                //Tell,
                //Email,
                //Sex,
                //City,
                //Village,
                //Em_Contact,
                //Emm_Name,
                //Emm_R,
                //Shift,
                //StaffType,
                //Salary
                //        );
                //StaffList.Add(staffs);
            }
        });

        return StaffList;
    }



    public struct Staffs
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DoB { get; set; }
        public string Tell { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string City { get; set; }
        public string Village { get; set; }
        public string Em_Contact { get; set; }
        public string Emm_Name { get; set; }
        public string Emm_R { get; set; }
        public string Shift { get; set; }
        public string StaffType { get; set; }
        public float Salary { get; set; }

        public Staffs(int id, string firstName, string lastName, string doB, string tell, string email, string sex, string city, string village, string em_Contact, string emm_Name, string emm_R, string shift, string staffType, float salary)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            DoB = doB;
            Tell = tell;
            Email = email;
            Sex = sex;
            City = city;
            Village = village;
            Em_Contact = em_Contact;
            Emm_Name = emm_Name;
            Emm_R = emm_R;
            Shift = shift;
            StaffType = staffType;
            Salary = salary;
        }
    }
}

