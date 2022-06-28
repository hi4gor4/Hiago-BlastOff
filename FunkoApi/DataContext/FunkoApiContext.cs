using FunkoApi.DataContext.Mapping;
using FunkoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FunkoApi.DataContext
{
    public class FunkoApiContext : DbContext
    {
        public DbSet<Colecao> Colecoes { get; set; }
        public DbSet<Funko> Funkos { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<FunkoLoja> FunkoLojas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        => options.UseSqlServer("Server=localhost,1433;Database=Crimes;User ID=sa;Password=1q2w3e4r@#$");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new ColecaoMapping());
            modelBuilder.ApplyConfiguration(new FunkoMapping());
            modelBuilder.ApplyConfiguration(new ImagemMapping());
            modelBuilder.ApplyConfiguration(new LojaMapping());
            modelBuilder.ApplyConfiguration(new FunkoLojaMapping());
            
        }


    }
}