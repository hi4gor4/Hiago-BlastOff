using FunkoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FunkoApi.DataContext.Mapping
{
    public class ColecaoMapping : IEntityTypeConfiguration<Colecao>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Colecao> builder)
        {
            builder.ToTable("Colecao");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            
            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(x => x.Tipo)
                .HasColumnName("tipo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(40)
                .IsRequired();
        }
    }
}