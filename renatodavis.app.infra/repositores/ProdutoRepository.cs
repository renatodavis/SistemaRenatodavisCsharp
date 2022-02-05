using renatodavis.app.domain.entities;
using renatodavis.app.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace renatodavis.app.infra.repositores
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public bool bExisteProduto(int id)
        {
            return Db.Set<Produto>().Any(e => e.ProdutoId == id);
        }
    }
}
