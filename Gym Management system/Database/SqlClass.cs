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
    private static string path = @"C:\Users\Farah\source\repos\Gym-Management-system\Gym Management system\Database\Gym.db";
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
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                
                Console.WriteLine( reader.GetString(0));

            }
            reader.Close();
        }
    }
}
