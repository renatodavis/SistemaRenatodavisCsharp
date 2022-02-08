using renatodavis.app.domain.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace renatodavis.app.domain.interfaces
{
    public interface IFornecedorRepository : IRepositoryBase<Fornecedor>
    {

        public bool bExiste(int id);
    }
}
