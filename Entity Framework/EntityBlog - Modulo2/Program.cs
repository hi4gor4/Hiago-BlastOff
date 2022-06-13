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
                // var adtag = new Tag{ Name= ".Net", Slug= "/net" };
                // context.Tags.Add(adtag);
                // context.SaveChanges();
                // var tag = context.Tags.FirstOrDefault(x=> x.Id ==1);
                // tag.Name = "Entity";
                // context.Update(tag);
                // context.Remove(tag);
                // context.SaveChanges();
                var tags = context
                .Tags
                .ToList();
                foreach(var tag in tags)//a execução só acontece quando é usado
                {
                    Console.WriteLine(tag.Name);
                }
            }
        }
    }
}