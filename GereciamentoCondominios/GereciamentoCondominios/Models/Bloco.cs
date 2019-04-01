using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GereciamentoCondominios.Models
{
    [Table("Table_Bloco")]
    public class Bloco
    {
        [Key]
        public int Pk_Bloco { get; set; }
        public string Numero { get; set; }
        public double Taxa { get; set; }
        public virtual ICollection<Apartamento> Apartamento { get; set; }
    }
}