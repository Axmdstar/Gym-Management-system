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

    public SqlClass()
	{
        
    }



    



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
        //using (SQLiteConnection connection = new SQLiteConnection(helper.ConnectionString))
        //{
        //    connection.Open();

        //    string query = @"";
        //    SQLiteCommand command = connection.CreateCommand();
        //    command.CommandText = query;
        //    command.ExecuteNonQuery();
        //}
        string q = @"INSERT INTO Customer_info(id, firstname, lastname) values('231','Ali','Muna')";
        helper.QueryWriter(q, r =>
        {
            Console.WriteLine(r.msg);
        });
    }

    //public void Login()
    //{

    //}

    //public void showtables()
    //{
    //    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
    //    {
    //        connection.Open();


    //        string query = @"SELECT name FROM sqlite_master WHERE type='table';";
    //        SQLiteCommand cmd = connection.CreateCommand();
    //        cmd.CommandText = query;
    //        SQLiteDataReader reader = cmd.ExecuteReader();

    //        while (reader.Read())
    //        {
                
    //            Console.WriteLine( reader.GetString(0));

    //        }
    //        reader.Close();
    //    }
    //}


    private void UserLogin(string username, string password)
    {

    }
}
