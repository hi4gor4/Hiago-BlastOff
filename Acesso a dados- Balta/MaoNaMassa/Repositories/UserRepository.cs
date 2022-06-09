using System.Data.SqlClient;
using Blog.Models;
using Dapper.Contrib.Extensions;

namespace Blog.Repositories
{

    public class UserRepository
    {
        public IEnumerable<User> ReadUsers(string CONNECTION_STRING)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING ))
            {
                return connection.GetAll<User>();
                
            }
        }
        public User Get(int id, string CONNECTION_STRING)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING ))
            {

                return connection.Get<User>(id);
                
            }
        }
    }
}