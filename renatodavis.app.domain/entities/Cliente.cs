﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace renatodavis.app.domain.entities
{
    [Table("Cliente")]
    public class Cliente
    {
        public Cliente()
        {

        }
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

    }
}
