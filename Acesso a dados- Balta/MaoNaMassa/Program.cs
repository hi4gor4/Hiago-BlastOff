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
            //CreateUser();
            UpdateUser();
            ReadUsers();
        }

        public static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING ))
            {
                var users = connection.GetAll<User>();
                foreach(var user in users)
                {
                    Console.WriteLine(user.Bio);
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
                Slug = "equipe-toodoo-blastoff2"

            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
                Console.WriteLine("Cadastro Efetuado");
            }
        }
        public static void UpdateUser()
        {
            var user = new User()
            {
                Id = 1,
                Bio = "Equipe Toodoo 2022",
                Email = "hiago23rangel@gmail.com",
                Image = "www.dwf.com",
                Name = "Equipe Blastoof",
                PasswordHash = "HASH",
                Slug = "equipe-toodoo-blastoff2"

            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);
                Console.WriteLine("Cadastro Atualizado");

            }
        }
        public static void DeleteUser()
        {
            

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);
                connection.Delete<User>(user);
                Console.WriteLine("Cadastro Atualizado");

            }
        }

    }
}