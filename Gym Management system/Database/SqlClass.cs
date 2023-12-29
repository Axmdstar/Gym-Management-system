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
    string query = @"SELECT id, firstname FROM staff_information";

        

        helper.QueryReader(query, r =>
        {
            Console.WriteLine(r.msg);

            //bool Error = r.msg.Contains("Error");
            //if (Error && r.ReaderData == null)
            //{
            //    Console.WriteLine(r.msg + " Error msg");
            //}
            //else
            //{
                //for (int i = 0; i < 3; i++)
                //{
                    Console.WriteLine(r.ReaderData.GetString(2));
                    //r.ReaderData.Read();

                //}
            //}
        });
    }


    public Dictionary<string, List<string>>  getTrainer()
    {
        string query = @"SELECT id, firstname FROM staff_information
                         where staff_type = 'Trainer'";

        Dictionary<string, List<string>> DictTrainer = new Dictionary<string, List<string>>();
        //DictTrainer.
        helper.QueryReader(query, r =>
        {
            if (r.ReaderData != null) { 
                while (r.ReaderData.Read())
                {
                    Console.WriteLine(r.ReaderData.GetString(0));
                    Console.WriteLine(r.ReaderData.GetString(1));
                    List<string> list = new List<string>
                    {
                        r.ReaderData.GetString(0), r.ReaderData.GetString(1)
                    };
                    DictTrainer.Add(r.ReaderData.GetString(1), list);
                }
            }
            Console.WriteLine(DictTrainer.Count);
        });
        return DictTrainer ;
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



    public List<string>? getPlans()
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
        return list ?? null;
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
}

