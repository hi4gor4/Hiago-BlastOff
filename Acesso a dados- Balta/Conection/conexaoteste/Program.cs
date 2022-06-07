using System;
using System.Data.SqlClient;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=Balta;User ID=sa;Password=1q2w3e4r@#$";
            var connection = new SqlConnection(connectionString);
            connection.Open();
            using(var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM CATEGORY";
                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine($"{reader.GetString(1)}");
                }

            }
            connection.Close();
        }
    }
}