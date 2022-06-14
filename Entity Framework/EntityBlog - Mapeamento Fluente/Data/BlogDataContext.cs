using EntityBlog.Mappings;
using EntityBlog.Models;
using Microsoft.EntityFrameworkCore;


namespace EntityBlog.Data
{
    public class BlogDataContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
       
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=BlogFluentMap;User ID=sa;Password=1q2w3e4r@#$");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new PostMap());

        }
    }
        
}
