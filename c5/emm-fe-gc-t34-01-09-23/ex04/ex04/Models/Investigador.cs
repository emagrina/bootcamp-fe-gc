using System;
using System.ComponentModel.DataAnnotations;

namespace ex04.Models
{
	public class Investigador
	{
        [Key]
        [StringLength(8)]
        public required string DNI { get; set; }

        [Required]
        [StringLength(255)]
        public required string NomApels { get; set; }

        public int FacultadCodigo { get; set; }
        public required Facultad Facultad { get; set; }

        public required ICollection<Reserva> Reservas { get; set; }
    }
}

