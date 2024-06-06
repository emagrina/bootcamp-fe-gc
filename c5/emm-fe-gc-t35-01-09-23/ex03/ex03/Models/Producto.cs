using System.ComponentModel.DataAnnotations;

namespace ex03.Models
{
	public class Producto
	{
        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nombre { get; set; }

        public int Precio { get; set; }

        public ICollection<Venta>? Ventas { get; set; }
    }
}

