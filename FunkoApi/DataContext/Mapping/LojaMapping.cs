using FunkoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FunkoApi.DataContext.Mapping;

public class LojaMapping : IEntityTypeConfiguration<Loja>
{
    public void Configure(EntityTypeBuilder<Loja> builder)
    {
        builder.ToTable("Loja");

        builder.HasKey(x => x.Id );

        builder.Property(x => x.Id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
        
        builder.Property(x => x.Nome)
            .HasColumnName("nome")
            .HasColumnType("VARCHAR")
            .HasMaxLength(80)
            .IsRequired();

        builder.Property(x => x.Localizacao)
            .HasColumnName("localizacao")
            .HasColumnType("VARCHAR")
            .HasMaxLength(80)
            .IsRequired();
        


    }
}
