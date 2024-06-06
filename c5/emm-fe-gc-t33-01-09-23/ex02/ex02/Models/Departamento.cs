using System.ComponentModel.DataAnnotations;

namespace ex02.Models
{
	public class Departamento
	{
        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nombre { get; set; }

        [Required]
        public int Presupuesto { get; set; }

        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    }
}

