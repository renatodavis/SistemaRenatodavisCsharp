using renatodavis.app.domain.entities;
using renatodavis.app.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace renatodavis.app.infra.repositores
{
    public class GrupoProdutoRepository : RepositoryBase<GrupoProduto>, IGrupoProdutoRepository
    {
        public bool bExiste(int id)
        {
            return Db.Set<GrupoProduto>().Any(e => e.GrupoProdutoId == id);
        }
    }
}
