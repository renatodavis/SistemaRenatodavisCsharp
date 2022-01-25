using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace renatodavis.app.domain.entities
{
    [Table("Produto")]
    public class Produto
    {
        public Produto()
        {

        }
        [Key]
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

    }
}
