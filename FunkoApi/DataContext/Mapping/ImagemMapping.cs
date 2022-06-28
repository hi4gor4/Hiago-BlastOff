using FunkoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FunkoApi.DataContext.Mapping
{
    public class ImagemMapping  : IEntityTypeConfiguration<Imagem>
    {
        public void Configure(EntityTypeBuilder<Imagem> builder)
        {
            builder.ToTable("Imagem");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            
            builder.Property(x=> x.Url)
                .HasColumnName("url")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();
            
            builder.HasOne(x=> x.Funko)
                .WithMany(x => x.Imagens)
                .HasForeignKey(x => x.IdFunko)
                .HasConstraintName("FK_Funko");
            
            

        }
    }
}