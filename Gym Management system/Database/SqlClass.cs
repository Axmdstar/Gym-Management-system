using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics;
using System.Data.SqlClient;


public class SqlClass
{
    private static string path = @"C:\Users\xusee\Source\Repos\Gym-Management-system\Gym Management system\Database\Gym.db";
    private static string ConnectionString = @$"Data Source={path};Version=3;";
    public string ConnetionStr { get { return ConnectionString; } }

    public SqlClass()
	{
        
    }


    public void showtables()
    {
        using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();


            string query = @"SELECT name FROM sqlite_master WHERE type='table';";
            string USERSQUERY = @"SELECT * FROM Customer_info";
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = USERSQUERY;
            SQLiteDataReader reader = cmd.ExecuteReader();
         

            while (reader.Read())
            {

                Console.WriteLine(reader.GetValue(0));
               // Console.WriteLine(reader.GetString(1));


            }
            reader.Close();
        }
    }

    public void CustomerData()
    {
        using (SQLiteConnection customerinfo = new SQLiteConnection(ConnectionString))
        {
            customerinfo.Open();

            string customerInfoQuery = @"INSERT INTO Customer_info (id, firstname, lastname) VALUES ('101', 'HUSSEIN', 'AHMED')";
            SQLiteCommand customerInfoComand = customerinfo.CreateCommand();
            customerInfoComand.CommandText = customerInfoQuery;
            customerInfoComand.ExecuteNonQuery();
            


            customerinfo.Close();
        }
    }
}
