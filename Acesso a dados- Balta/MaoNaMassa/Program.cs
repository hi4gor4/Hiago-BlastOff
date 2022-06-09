using System.Data.SqlClient;
using Blog.Models;
using Dapper.Contrib.Extensions;

namespace Blog
{
    class Program
    {
        private const string  CONNECTION_STRING =  @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word");
        }

        public static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING ))
            {
                var users = connection.GetAll<User>();
                foreach(var user in users)
                {
                    Console.WriteLine(user.Email);
                }
            }
        }
    }
}