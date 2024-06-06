using System.ComponentModel.DataAnnotations;

namespace ex02.Models
{
    public class Cientifico
    {
        [Key]
        [StringLength(8)]
        public required string Dni { get; set; }

        [StringLength(255)]
        public required string NomApels { get; set; }

        public required ICollection<Asignado_A> Asignados { get; set; }
    }
}

