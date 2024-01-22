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
using System.Windows.Controls.Primitives;

public class SqlClass
{
    Helper helper = new Helper();
    public string ConnetionStr { get { return helper.ConnectionString; } }






    // Get Methods
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


    // Get Plans
    public List<string> getPlans()
    {
        string query = @"select plan_name from plans";
        List<string> list = new List<string>();
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                list.Add(r.ReaderData.GetString(0));
            }
        });
        return list;
    }

    // Get Trainers
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
    // Get Staff
    public List<StaffModal> GetStaffData(string query)
    {
        List<StaffModal> StaffList = new List<StaffModal>();
        Console.WriteLine(query);
        if (query == "")
        {
            query = @"SELECT * FROM staff_information";
        }
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                //int planId = r.ReaderData.IsDBNull(9) ? 0 : r.ReaderData.GetInt32(9);

                int id = r.ReaderData.IsDBNull(0) ? 0 : r.ReaderData.GetInt32(0);
                string FirstName = r.ReaderData.IsDBNull(1) ? "null" : r.ReaderData.GetString(1);
                string LastName = r.ReaderData.IsDBNull(2) ? "null" : r.ReaderData.GetString(2);
                string DoB = r.ReaderData.IsDBNull(3) ? "null" : r.ReaderData.GetString(3);
                string Tell = r.ReaderData.IsDBNull(4) ? "null" : r.ReaderData.GetString(4);
                string Email = r.ReaderData.IsDBNull(5) ? "null" : r.ReaderData.GetString(5);
                string Sex = r.ReaderData.IsDBNull(6) ? "null" : r.ReaderData.GetString(6);
                string City = r.ReaderData.IsDBNull(7) ? "null" : r.ReaderData.GetString(7);
                string Village = r.ReaderData.IsDBNull(8) ? "null" : r.ReaderData.GetString(8);
                string Em_Contact = r.ReaderData.IsDBNull(9) ? "null" : r.ReaderData.GetString(9);
                string Emm_Name = r.ReaderData.IsDBNull(10) ? "null" : r.ReaderData.GetString(10);
                string Emm_R = r.ReaderData.IsDBNull(11) ? "null" : r.ReaderData.GetString(11);
                string Shift = r.ReaderData.IsDBNull(12) ? "null" : r.ReaderData.GetString(12);
                string StaffType = r.ReaderData.IsDBNull(13) ? "null" : r.ReaderData.GetString(13);
                float Salary = r.ReaderData.IsDBNull(14) ? 0 : r.ReaderData.GetFloat(14);

                //StaffObject
                StaffModal staffs = new StaffModal(
                id,
                FirstName,
                LastName,
                DoB,
                Tell, Email,
                Sex,
                City,
                Village,
                Em_Contact,
                Emm_Name,
                Emm_R,
                Shift,
                StaffType,
                Salary
                        );
                StaffList.Add(staffs);
            }
            Console.WriteLine(StaffList.Count);
        });

        return StaffList;
    }

    public List<MemberShipModal> GetMembersData(string query)
    {
        List<MemberShipModal> MemberList = new List<MemberShipModal>();
        Console.WriteLine(query);
        if (query == "")
        {
            query = @"select * from Customer_info";
        }
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.Read())
            {
                int id = r.ReaderData.GetInt32(0);
                string FirstName = r.ReaderData.IsDBNull(1) ? "null" : r.ReaderData.GetString(1);
                string LastName = r.ReaderData.IsDBNull(2) ? "null" : r.ReaderData.GetString(2);
                string DoB = r.ReaderData.IsDBNull(3) ? "null" : r.ReaderData.GetString(3);
                string Tell = r.ReaderData.IsDBNull(4) ? "null" : r.ReaderData.GetString(4);
                string Email = r.ReaderData.IsDBNull(5) ? "null" : r.ReaderData.GetString(5);
                string Sex = r.ReaderData.IsDBNull(6) ? "null" : r.ReaderData.GetString(6);
                float Weight = r.ReaderData.IsDBNull(7) ? 0 : r.ReaderData.GetFloat(7);
                string City = r.ReaderData.IsDBNull(8) ? "null" : r.ReaderData.GetString(8);
                string Village = r.ReaderData.IsDBNull(9) ? "null" : r.ReaderData.GetString(9);
                string Em_Contact = r.ReaderData.IsDBNull(10) ? "null" : r.ReaderData.GetString(10);
                string Emm_Name = r.ReaderData.IsDBNull(11) ? "null" : r.ReaderData.GetString(11);
                string Emm_R = r.ReaderData.IsDBNull(12) ? "null" : r.ReaderData.GetString(12);
                int PlansId = r.ReaderData.IsDBNull(13) ? 0 : r.ReaderData.GetInt32(13);

                //MemberObject
                MemberShipModal member = new MemberShipModal(
                id,
                FirstName,
                LastName,
                DoB,
                Tell,
                Email,
                Sex,
                City,
                Village,
                Em_Contact,
                Emm_Name,
                Emm_R,
                Weight,
                PlansId
                );
                MemberList.Add(member);
            }
        });

        return MemberList;
    }





    public void ExcuteQuery(string query)
    {
        helper.QueryWriter(query, r =>
        {
            Console.WriteLine(r.msg);
        });
    }

    //Add Methods
    public void AddPlantoDb(string query)
    {
        helper.QueryWriter(query, r =>
        {
            Console.WriteLine(r.msg);
        });
    }

    //public void AddStaffToDb(string query)
    //{
    //    helper.QueryWriter(query, r => {
    //        Console.WriteLine(r.msg);
    //    });
    //}


    //// Delete Methods
    //public void DeletePlanFromDb(string query)
    //{
    //    helper.QueryWriter(query, r =>
    //    {
    //        Console.WriteLine(r.msg);
    //    });
    //}

    public void DeleteStaff(int id)
    {
        string query = $@"DELETE from staff_information where id = {id};";
        helper.QueryWriter(query, r =>
        {
            Console.WriteLine(r.msg);
        });
    }

    // update Methods

    //public void EditStaffToDb(string query)
    //{
    //   helper.QueryWriter(query, r => {  
    //       Console.WriteLine(r.msg);
    //   });
    //}



    





    


    //public struct Staffs
    //{
    //}
}

