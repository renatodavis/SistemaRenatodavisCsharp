using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace renatodavis.app.domain.entities
{
    [Table("GrupoProduto")]
    public class GrupoProduto
    {
        [Key]
        public int GrupoProdutoId { get; set; }
        public string Nome { get; set; }

    }
}
