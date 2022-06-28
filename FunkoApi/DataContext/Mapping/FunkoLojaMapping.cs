using FunkoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FunkoApi.DataContext.Mapping;

public class FunkoLojaMapping : IEntityTypeConfiguration<FunkoLoja>
{
    public void Configure(EntityTypeBuilder<FunkoLoja> builder)
    {
        builder.ToTable("FunkoLoja");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
        
        builder.Property(x => x.Quantidade)
            .HasColumnName("quantidade")
            .HasColumnType("INT")
            .IsRequired();
        
        builder.HasOne(x => x.Funko)
            .WithMany(x => x.FunkoLojas)
            .HasForeignKey(x => x.idFunko)
            .HasConstraintName("FK_Funko_IN_FunkoLoja");
        
        builder.HasOne(x => x.Loja)
            .WithMany(x => x.FunkoLojas)
            .HasForeignKey(x => x.idLoja)
            .HasConstraintName("Fk_Loja");

    }
}