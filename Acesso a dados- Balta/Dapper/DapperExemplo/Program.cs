using System;
using System.Data.SqlClient;
using Dapper;
using DataAccess.Model;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=Balta;User ID=sa;Password=1q2w3e4r@#$";
            using(var connection = new SqlConnection(connectionString))
            {
                var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
                foreach (var category in categories)
                {
                    Console.WriteLine($"{category.Title}, {category.Id}");
                }
            }
        }
    }
}