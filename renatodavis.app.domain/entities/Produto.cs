using System;
using System.Collections.Generic;
using System.Text;

namespace renatodavis.app.domain.entities
{
    public class Produto
    {
        public Produto()
        {

        }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

    }
}
