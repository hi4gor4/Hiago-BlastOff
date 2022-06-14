using EntityBlog.Models;
using Microsoft.EntityFrameworkCore;


namespace EntityBlog.Data
{
    public class BlogDataContext: DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$");
        }

    }
        
}
