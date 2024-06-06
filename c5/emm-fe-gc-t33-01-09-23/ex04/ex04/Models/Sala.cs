using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex04.Models
{
	public class Sala
	{
        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nombre { get; set; }

        [ForeignKey("Pelicula")]
        public int PeliculaCodigo { get; set; }

        public Pelicula? Pelicula { get; set; }
    }
}

