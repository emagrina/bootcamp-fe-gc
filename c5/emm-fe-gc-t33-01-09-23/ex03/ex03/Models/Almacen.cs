using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex03.Models
{
	public class Almacen
	{
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Codigo { get; set; }

        [StringLength(100)]
        public string? Lugar { get; set; }

        [Required]
        public int Capacidad { get; set; }

        public ICollection<Caja> Cajas { get; set; } = new List<Caja>();
    }
}

