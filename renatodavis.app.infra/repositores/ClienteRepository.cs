using Microsoft.EntityFrameworkCore;
using renatodavis.app.domain.entities;
using renatodavis.app.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace renatodavis.app.infra.repositores
{
    public class ClienteRepository : RepositoryBase<Cliente>,IClienteRepository
    {
        public async Task<List<Cliente>> GetClientesAsync()
        {
            return (List<Cliente>) await  GetAll();
        }

        public async void RemoverCliente(int id)
        {
            var cliente = await GetById(id);
            Db.Remove(cliente);
        }
        public bool bExisteCliente(int id)
        {
            return Db.Set<Cliente>().Any(e => e.ClienteId == id);
        }

        public bool bExisteEmail(string email)
        {
            return Db.Set<Cliente>().Any(e => e.email == email);
        }

        
    }
}
