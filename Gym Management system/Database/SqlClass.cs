using System;
using System.Data.SqlClient;
using System.Data.SQLite;

public class SqlClass
{
    string connectionString = "Data Source=GymDataBase.db;Version=3;Compress=true;";
    SQLiteConnection Connection;

    public SqlClass()
	{
        SQLiteConnection Connection = new SQLiteConnection(connectionString);
    }


    public void showtable()
    {
       // using (SQLiteCommand command = new SQLiteCommand("select * from Staff_Information"))
        {
        //    using(SQLiteDataReader reader = command.ExecuteReader())
        
        //    {
         //       while (reader.Read())
           //     {
             ///       Console.WriteLine(reader.GetString(0)); 
                //    Console.WriteLine(reader.GetString(1));
           //     }
        //    }
        }
    }
}
