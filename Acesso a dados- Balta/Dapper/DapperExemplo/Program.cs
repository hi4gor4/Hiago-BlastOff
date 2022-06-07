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
               ListCategories(connection);
               CreateCategory(connection);
            }
        }
        static void ListCategories(SqlConnection connection)
        {
             var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
            foreach (var item in categories)
            {
                Console.WriteLine($"{item.Title}, {item.Id}");
            }
        }
        static void CreateCategory(SqlConnection connection)
        {
            var category = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "Mqtt";
            category.Url = "www.nada.com";
            category.Description = "Categoria destinada a serviços do AWS";
            category.Order = 8;
            category.Summary = "AWS Cloud";
            category.Featured = false;
            var insert = @"INSERT INTO 
                [Category] 
            VALUES(
                @Id,
                @Title,
                @Url,
                @Summary,
                @Order,
                @Description,
                @Featured)";
            var rows = connection.Execute(insert, new{
                    category.Id,
                    category.Title,
                    category.Url,
                    category.Summary,
                    category.Order,
                    category.Description,
                    category.Featured
                });
        }
        static void UpdateCategory(SqlConnection connection)
        {
            var UpdateQuery = "Update [Category] SET [Title] = @title WHERE [Id] = @id";
            var rows = connection.Execute(UpdateQuery, new{
                id = new Guid("3b9a2545-dd4d-488b-a367-6416a9c3823b"),
                title = "Curso mqtt"
            });
            Console.WriteLine("registros atualizados");
        }
    }
}