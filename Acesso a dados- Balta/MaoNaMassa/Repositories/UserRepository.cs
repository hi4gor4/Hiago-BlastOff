using System.Data.SqlClient;
using Blog.Models;
using Dapper.Contrib.Extensions;

namespace Blog.Repositories
{

    public class UserRepository
    {
        private const string  CONNECTION_STRING =  @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";
        public IEnumerable<User> ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING ))
            {
                var users = connection.GetAll<User>();
                return users;
            }
        }
    }
}