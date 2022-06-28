using FunkoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FunkoApi.DataContext.Mapping
{
    public class FunkoMapping : IEntityTypeConfiguration<Funko>
    {
        public void Configure(EntityTypeBuilder<Funko> builder)
        {
            builder.ToTable("Funko");

            builder.HasKey(x => x.Id);

            builder.Property(x =>x.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            
            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(x => x.Lancamento)
                .HasColumnName("lancamento")
                .HasColumnType("DATE")
                .IsRequired();

            builder.Property(x => x.Numero)
                .HasColumnName("numero")
                .HasColumnType("INT")
                .IsRequired();
            
            builder.Property(x => x.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();

            builder.HasOne(x => x.Colecao)
                .WithMany(x => x.Funkos)
                .HasForeignKey(x => x.IdColecao)
                .HasConstraintName("Fk_Colecao");


        }
    }
}