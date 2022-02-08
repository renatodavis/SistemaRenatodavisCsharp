using renatodavis.app.domain.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace renatodavis.app.domain.interfaces
{
    public interface IGrupoProdutoRepository : IRepositoryBase<GrupoProduto>
    {

        public bool bExiste(int id);
    }
}
