using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locadora.Models
{
    [Table("Locacao")]
    public class Locacao
    {
        public int Id{ get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Filme{ get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}