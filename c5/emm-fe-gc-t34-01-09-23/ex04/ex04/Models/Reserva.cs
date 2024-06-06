using System.ComponentModel.DataAnnotations;

namespace ex04.Models
{
	public class Reserva
	{
        [Key]
        [StringLength(8)]
        public string DNI { get; set; }

        [Key]
        [StringLength(4)]
        public string NumSerie { get; set; }

        public DateTime Comienzo { get; set; }
        public DateTime Fin { get; set; }

        public Investigador Investigador { get; set; }
        public Equipo Equipo { get; set; }

    }
}

