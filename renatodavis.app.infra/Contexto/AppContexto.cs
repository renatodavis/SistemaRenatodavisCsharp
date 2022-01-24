using Microsoft.EntityFrameworkCore;
using renatodavis.app.domain.entities;

namespace renatodavis.app.infra.Contexto
{
    public class AppContexto : DbContext
    {
        public AppContexto(DbContextOptions<AppContexto> options  ):base(options)
        {

        }
        
        // Mapeamento das entidades
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        // configurações do EF 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Cliente>().ToTable("Produto");
            modelBuilder.Entity<Cliente>().ToTable("Fornecedor");

        }
    }
}
