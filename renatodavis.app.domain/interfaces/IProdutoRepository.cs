using renatodavis.app.domain.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace renatodavis.app.domain.interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {

        public bool bExisteProduto(int id);

        public IList<Cliente> Clientes();

        public IList<GrupoProduto> GrupoProdutos();

    }
}
