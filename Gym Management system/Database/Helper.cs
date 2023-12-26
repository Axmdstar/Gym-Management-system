using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Gym_Management_system.Database
{
    public class Helper
    {
        private static string path = @"C:\Users\Farah\source\repos\Gym-Management-system\Gym Management system\Database\Gym.db";
        public string ConnectionString = @$"Data Source={path};Version=3;";




        //public Dictionary<string, SQLiteDataReader> Result = new Dictionary<string, SQLiteDataReader>();

        public struct Result
        {
            public SQLiteDataReader? ReaderData;
            public string msg;

            public Result(SQLiteDataReader? readerData, string msg)
            {
                this.ReaderData = readerData;
                this.msg = msg;
            }
        }


        public void QueryReader(string query, Action<Result> processResults)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();


                    SQLiteCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if(!reader.Read())
                    {
                        throw new Exception();
                    } else
                    {
                        Result r = new Result(reader, "Succesfull");
                        processResults(r);
                    }
                    connection.Close();
                }
            }
            
            catch (Exception err)
            {
                
                string msg = err.Message;
                Result r = new Result(null, "Error::" + msg);
                processResults(r);

            }
            
        }



        public void QueryWriter(string query, Action<Result> processResults)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    SQLiteCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    Result r = new Result(null, "Succesfull");
                    processResults(r);

                    connection.Close();
                }
                
            }
            catch (Exception err)
            {

                string msg = err.Message;
                Result r = new Result(null, "Error::" + msg);
                processResults(r);
                
            }
            
        }
    }
}
