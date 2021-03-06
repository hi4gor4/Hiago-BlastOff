using EntityBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EntityBlog.Data
{
    public class BlogDataContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }//Crie nome da propriedade como o modelo no plural
        public DbSet<Post> Posts { get; set; }
        //public DbSet<PostTag> PostTags{ get; set; }
        //public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$");
        }

    }
        
}
