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
                var adtag = new Tag{ Name= "ASP", Slug= "/asp" };
                context.Tags.Add(adtag);
                context.SaveChanges();
                // var tag = context.Tags.FirstOrDefault(x=> x.Id ==1);
                // tag.Name = "Entity";
                // context.Update(tag);
                // context.Remove(tag);
                // context.SaveChanges();
                var tags = context.Tags;
                foreach(var tag in tags)
                {
                    Console.WriteLine(tag.Name);
                }
            }
        }
    }
}