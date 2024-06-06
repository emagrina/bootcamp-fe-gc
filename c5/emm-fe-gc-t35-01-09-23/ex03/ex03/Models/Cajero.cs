using System;
using System.ComponentModel.DataAnnotations;

namespace ex03.Models
{
	public class Cajero
	{
        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(255)]
        public required string NomApels { get; set; }

        public ICollection<Venta>? Ventas { get; set; }
    }
}

