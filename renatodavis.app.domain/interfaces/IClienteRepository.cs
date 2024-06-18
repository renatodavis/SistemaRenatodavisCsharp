using renatodavis.app.domain.entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace renatodavis.app.domain.interfaces
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        public Task<List<Cliente>> GetClientesAsync();
        public void RemoverCliente(int id);
        public bool bExisteCliente(int id);
        public bool bExisteEmail(string email);
    }
}
