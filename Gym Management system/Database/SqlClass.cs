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
                    Console.WriteLine(r.ReaderData.GetString(0) );
                    r.ReaderData.Read();

                }
                //while (r.ReaderData.Read())
                //{
                //    Console.WriteLine(r.ReaderData.GetString(0));
                //}
            }
        });
    }



    //public void getPlansDshBdData()
    //{
    //    string query = @"SELECT p.plan_name, p.signup_fee, p.price, p.plan_type, si.firstname, si.tell, si.shift, sch.time_in, sch.time_out from plans as p
    //      LEFT JOIN staff_information as si on p.staff_id = si.id
    //      LEFT join schedule as sch on  sch.plan_id = p.id";

    //    Console.WriteLine("Get Plans is Called");

    //    helper.QueryReader(query, r => {

    //        while (r.ReaderData.Read())
    //        {
    //            r.ReaderData["time_out"].ToString();
    //            r.ReaderData["time_in"].ToString();
    //            //Console.WriteLine("Why");
    //            Console.Write(r.ReaderData.GetString(0) +
    //                    r.ReaderData.GetString(1)  + " " +
    //                    r.ReaderData.GetString(2)  + " " +
    //                    r.ReaderData.GetString(3)  + " " +
    //                    r.ReaderData.GetString(4)  + " " +
    //                    r.ReaderData.GetString(5)  + " " +
    //                    r.ReaderData.GetString(6)  + " " +
    //                    r.ReaderData.GetString(7)  + " " +
    //                    r.ReaderData.GetString(8) );
    //            r.ReaderData.Read();
    //        }
    //    });
    //}

    public Dictionary<string, List<object>> getPlansDshBdData()
    {
        string query = @"SELECT p.plan_name, p.signup_fee, p.price, p.plan_type, si.firstname, si.tell, si.shift, sch.time_in, sch.time_out from plans as p
        LEFT JOIN staff_information as si on p.staff_id = si.id
        LEFT JOIN schedule as sch on sch.plan_id = p.id";

        Dictionary<string, List<object>> Dict = new Dictionary<string, List<object>>();

        int count = 0;
        helper.QueryReader(query, r =>
        {
            while (r.ReaderData != null && r.ReaderData.Read())
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
                    timeOut
                };

                //Console.WriteLine($"{planName} {signupFee} {price} {planType} {firstname} {tell} {shift} {timeIn} {timeOut}");
                Dict.Add(planName, list);
                count++;
            }
        });

        return Dict;

    }






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
}

