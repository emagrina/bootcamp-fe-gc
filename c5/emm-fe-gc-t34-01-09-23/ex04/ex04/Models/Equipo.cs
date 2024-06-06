using System;
using System.ComponentModel.DataAnnotations;

namespace ex04.Models
{
	public class Equipo
	{
        [Key]
        [StringLength(4)]
        public required string NumSerie { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nombre { get; set; }

        public int FacultadCodigo { get; set; }
        public required Facultad Facultad { get; set; }

        public required ICollection<Reserva> Reservas { get; set; }
    }
}

