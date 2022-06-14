using EntityBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityBlog.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");// define a tabela
            
            builder.HasKey(x => x.Id);

            builder.Property(x=> x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x=> x.Name)// Definindo instruções fluentes
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnName("NVARCHAR")
                .HasMaxLength(80);
            
            builder.Property(x=> x.Slug)// Definindo instruções fluentes
                .IsRequired()
                .HasColumnName("Slug")
                .HasColumnName("VARCHAR")
                .HasMaxLength(80);
            
            builder.HasIndex(x=> x.Slug, "IX_Category_Slug")
                .IsUnique();
        }
    }
}