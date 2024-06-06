using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex03.Models
{
	public class Caja
	{
        [Key]
        [StringLength(5)]
        public required string NumReferencia { get; set; }

        [StringLength(100)]
        public string? Contenido { get; set; }

        [Required]
        public int Valor { get; set; }

        [ForeignKey("Almacen")]
        public int AlmacenCodigo { get; set; }

        public Almacen? Almacen { get; set; }
    }
}

