using Microsoft.EntityFrameworkCore;
using renatodavis.app.domain.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace renatodavis.app.infra.Contexto
{
    public class AppContexto : DbContext
    {
        public AppContexto(DbContextOptions<AppContexto> options  ):base(options)
        {

        }
        
        // Mapeamento das entidades
        public DbSet<Cliente> Clientes { get; set; }

        // configurações do EF 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
