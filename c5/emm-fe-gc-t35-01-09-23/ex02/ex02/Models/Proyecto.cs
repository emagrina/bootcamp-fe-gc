using System.ComponentModel.DataAnnotations;

namespace ex02.Models
{
    public class Proyecto
    {
        [Key]
        [StringLength(4)]
        public required string Id { get; set; }

        [Required]
        [StringLength(255)]
        public required string Nombre { get; set; }

        public int Horas { get; set; }

        public required ICollection<Asignado_A> Asignados { get; set; }
    }
}

