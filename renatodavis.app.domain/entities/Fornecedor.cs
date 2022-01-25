using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace renatodavis.app.domain.entities
{
    [Table("Fornecedor")]
    public class Fornecedor

    {
        [Key]
        public int FornecedorId { get; set; }
        public string Descricao { get; set; }
        

    }
}
