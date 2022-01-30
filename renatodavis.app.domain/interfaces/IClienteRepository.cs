using renatodavis.app.domain.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace renatodavis.app.domain.interfaces
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {

        public bool bExisteCliente(int id);
    }
}
