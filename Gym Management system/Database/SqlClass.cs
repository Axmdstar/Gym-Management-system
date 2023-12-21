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
        string query = @"SELECT name FROM sqlite_master WHERE type='table';";

        helper.QueryReader(query, r =>
        {
            bool Error = r.msg.Contains("Error");
            if ( Error && r.ReaderData == null)
            {
                Console.WriteLine(r.msg);
            } else
            {
                while (r.ReaderData.Read())
                {
                    Console.WriteLine(r.ReaderData.GetString(0));
                }
            }
        });
    }

    public void Customer()
    {
        string q = @"INSERT INTO Customer_info(id, firstname, lastname) values('231','Ali','Muna')";
        helper.QueryWriter(q, r =>
        {
            Console.WriteLine(r.msg);
        });
    }




    private void UserLogin(string username, string password)
    {
        //Demo
        //username = "Ali";
        //password = "Password";

        //string query = @"SELECT * FROM";
    }
}

