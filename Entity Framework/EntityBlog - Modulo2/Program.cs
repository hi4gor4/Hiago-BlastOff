using System;
using EntityBlog.Data;
using EntityBlog.Models;

namespace EntityBlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BlogDataContext())
            {
                var user = new User
                {
                    Name = "Hiago rRangel",
                    Slug = "hiagora",
                    Email = "hiago.toodoo",
                    Bio = "blastofer",
                    Image = "https://goo.com",
                    PasswordHash = "123098457"
                };
                
                var category = new Category {Name = "Backend", Slug = "backend"};
                
                var post = new Post
                {
                    Author = user,
                    Category = category,
                    Body = "<p>Hello world</p>",
                    Slug = "comecando-com-ef-core",
                    Summary = "Neste artigo vamos aprender EF core",
                    Title = "Começando com EF Core",
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                };
                
                context.Posts.Add(post); 
                context.SaveChanges();
            }
            }
        }
    }
