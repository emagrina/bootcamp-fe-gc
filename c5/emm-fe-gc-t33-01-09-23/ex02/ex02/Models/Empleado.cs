using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex02.Models
{
	public class Empleado
	{
        [Key]
        [StringLength(8)]
        public required string Dni { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string? Apellidos { get; set; }

        [ForeignKey("Departamento")]
        public int DepartamentoCodigo { get; set; }

        public Departamento? Departamento { get; set; }
    }
}

