using System.Data.SqlClient;

    class Program
    {
        static void Main(string[] ars)
        {
            const string connectionString  = "Server=localhost,1433;Database=Balta;User ID=sa;Password=1q2w3e4r@#$ ";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT [Id], [Title] from [Category]";
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                    }
                }
                Console.WriteLine("Conectado");    
            }
            Console.WriteLine("Batata e pera");
            
            
        }
    }
