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
            CreateUser();
            ReadUsers();
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

        public static void CreateUser()
        {
            var user = new User()
            {
                Bio = "Equipe Toodoo",
                Email = "hiago23rangel@gmail.com",
                Image = "www.dwf.com",
                Name = "Equipe Blastoof",
                PasswordHash = "HASH",
                Slug = "equipe-toodoo-blastoff"

            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
                Console.WriteLine("Cadastro Efetuado");
            }
        }
    }
}