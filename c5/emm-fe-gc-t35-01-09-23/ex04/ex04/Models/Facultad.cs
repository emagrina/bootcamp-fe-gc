using System.ComponentModel.DataAnnotations;

namespace ex04.Models
{
	public class Facultad
	{
        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nombre { get; set; }

        public required ICollection<Investigador> Investigadores { get; set; }
        public required ICollection<Equipo> Equipos { get; set; }
    }
}

