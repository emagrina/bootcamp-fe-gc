using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex03.Models
{
    public class Venta
    {
        [Key, Column(Order = 0)]
        public int CajeroCodigo { get; set; }

        [Key, Column(Order = 1)]
        public int ProductoCodigo { get; set; }

        [Key, Column(Order = 2)]
        public int MaquinaCodigo { get; set; }

        [ForeignKey("CajeroCodigo")]
        public Cajero Cajero { get; set; }

        [ForeignKey("ProductoCodigo")]
        public Producto Producto { get; set; }

        [ForeignKey("MaquinaCodigo")]
        public MaquinaRegistradora Maquina { get; set; }
    }
}
