using System.ComponentModel.DataAnnotations;

namespace ex01.Models
{
	public class Proveedor
	{
        [Key]
        [StringLength(4)]
        public required string Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nombre { get; set; }

        public Suministra? Suministra { get; set; }
    }
}

