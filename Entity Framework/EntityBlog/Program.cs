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
                // var tag = new Tag{ Name= "ASP", Slug= "/asp" };
                // context.Tags.Add(tag);
                // context.SaveChanges();
                var tag = context.Tags.FirstOrDefault(x=> x.Id ==1);
                tag.Name = "Entity";
                context.SaveChanges();
            }
        }
    }
}