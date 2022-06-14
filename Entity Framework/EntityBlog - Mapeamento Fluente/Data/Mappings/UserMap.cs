using EntityBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityBlog.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);
            
            builder.Property(x=> x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x=> x.Name);
            builder.Property(x=> x.Bio);
            builder.Property(x=> x.Image);
            builder.Property(x=> x.Email);
            builder.Property(x=> x.PasswordHash);
            builder.Property(x=> x.Slug);




        }
    }
}