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
        static void CreateManyCategories(SqlConnection connection)
        {
            var category = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "Mqtt";
            category.Url = "www.nada.com";
            category.Description = "Categoria destinada a serviços do AWS";
            category.Order = 8;
            category.Summary = "AWS Cloud";
            category.Featured = false;
            var category2 = new Category();
            category2.Id = Guid.NewGuid();
            category2.Title = "Mqtt ewrfg";
            category2.Url = "www.nada.com";
            category2.Description = "Categoria destinada a serviços do AWS";
            category2.Order = 8;
            category2.Summary = "AWS Cloud";
            category2.Featured = false;
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
            var rows = connection.Execute(insert, new[]{
                new{
                    category.Id,
                    category.Title,
                    category.Url,
                    category.Summary,
                    category.Order,
                    category.Description,
                    category.Featured
                },
                new{
                    category2.Id,
                    category2.Title,
                    category2.Url,
                    category2.Summary,
                    category2.Order,
                    category2.Description,
                    category2.Featured
                }
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
        static void ExecuteReadProcedure(SqlConnection connection)
        {
            var procedure = "[spGetCourseByCategory]";
            var parames = new  {CategoryId = "5d8cf24e-e717-9a02-2443-01b300000000"};
            var courses =  connection.Query(
                procedure,
                parames,
                commandType: System.Data.CommandType.StoredProcedure
            );
            foreach (var item in courses)
            {
                Console.WriteLine(item.Id);
            }

        }
        static void ExecuteScalar(SqlConnection connection)
        {
            var category = new Category();
            category.Title = "Amazon AWS";
            category.Url = "amazon";
            category.Description = "Categoria destinada a serviços do AWS";
            category.Order = 8;
            category.Summary = "AWS Cloud";
            category.Featured = false;

            var insertSql = @"
                INSERT INTO 
                    [Category] 
                OUTPUT inserted.[Id]
                VALUES(
                    NEWID(), 
                    @Title, 
                    @Url, 
                    @Summary, 
                    @Order, 
                    @Description, 
                    @Featured) 
                ";
            var id = connection.ExecuteScalar<Guid>(insertSql, new
            {
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featured
            });
            Console.WriteLine($"CCategoria inserida: {id}");
        }
        static void ReadView(SqlConnection connection)
        {
            var sql = "SELECT * FROM [vwCourses]";
            var courses = connection.Query(sql);

            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Id} - {item.Title}");
            }
        }
        static void OneToOne(SqlConnection connection)
        {
            var sql = @"
                SELECT 
                    * 
                FROM 
                    [CareerItem] 
                INNER JOIN 
                    [Course] ON [CareerItem].[CourseId] = [Course].[Id]";

            var items = connection.Query<CareerItem, Course, CareerItem>(
                sql,
                (careerItem, course) =>
                {
                    careerItem.Course = course;
                    return careerItem;
                }, splitOn: "Id");

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Title} - Curso: {item.Course.Title}");
            }
        }
        static void OneToMany(SqlConnection connection)
        {
            var sql = @"
                SELECT 
                    [Career].[Id],
                    [Career].[Title],
                    [CareerItem].[CareerId],
                    [CareerItem].[Title]
                FROM 
                    [Career] 
                INNER JOIN 
                    [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id]
                ORDER BY
                    [Career].[Title]";

            var careers = new List<Career>();
            var items = connection.Query<Career, CareerItem, Career>(
                sql,
                (career, item) =>
                {
                    var car = careers.Where(x => x.Id == career.Id).FirstOrDefault();
                    if (car == null)
                    {
                        car = career;
                        car.Items.Add(item);
                        careers.Add(car);
                    }
                    else
                    {
                        car.Items.Add(item);
                    }

                    return career;
                }, splitOn: "CareerId");

            foreach (var career in careers)
            {
                Console.WriteLine($"{career.Title}");
                foreach (var item in career.Items)
                {
                    Console.WriteLine($" - {item.Title}");
                }
            }
        }
    }
}