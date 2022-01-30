using renatodavis.app.domain.entities;
using renatodavis.app.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace renatodavis.app.infra.repositores
{
    public class ClienteRepository : RepositoryBase<Cliente>,IClienteRepository
    {
        public bool bExisteCliente(int id)
        {
            return Db.Set<Cliente>().Any(e => e.ClienteId == id);
        }
    }
}
