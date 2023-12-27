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
        string query = @"select plan_name from plans";

        helper.QueryReader(query, r =>
        {
            bool Error = r.msg.Contains("Error");
            if ( Error && r.ReaderData == null)
            {
                Console.WriteLine(r.msg);
            } else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(r.ReaderData.GetString(0));
                    r.ReaderData.Read();

                }
                //while (r.ReaderData.Read())
                //{
                //    Console.WriteLine(r.ReaderData.GetString(0));
                //}
            }
        });
    }



    public void getPlansDshBdData()
    {
        string query = @"SELECT p.plan_name, p.signup_fee, p.price, p.plan_type, si.firstname, si.tell, si.shift, sch.time_in, sch.time_out from plans as p
          LEFT JOIN staff_information as si on p.staff_id = si.id
          LEFT join schedule as sch on  sch.plan_id = p.id";

        helper.QueryReader(query, r => { 

        });
    }


    public List<string> getPlans()
    {
        string query = @"select plan_name from plans";
        List<string> list = new List<string>();
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData.HasRows)
            {
                //Console.WriteLine(r.ReaderData.GetString(0));
                list.Add(r.ReaderData.GetString(0));
                r.ReaderData.Read();
                
            }
            
        });
        return list;
    }
}

