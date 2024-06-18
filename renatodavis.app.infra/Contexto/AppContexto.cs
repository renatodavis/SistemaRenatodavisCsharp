using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using renatodavis.app.domain.entities;
using System.Configuration;

namespace renatodavis.app.infra.Contexto
{
    public class AppContexto : DbContext
    {
        public AppContexto(DbContextOptions<AppContexto> options) : base(options)
        {
            

        }
        public AppContexto() :base()
        {
            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=LojaDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
        // Mapeamento das entidades
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<GrupoProduto> GrupoProdutos { get; set; }


        // configurações do EF 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            

            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<GrupoProduto>().ToTable("GrupoProdutos");
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedores");

        }
    }
}
