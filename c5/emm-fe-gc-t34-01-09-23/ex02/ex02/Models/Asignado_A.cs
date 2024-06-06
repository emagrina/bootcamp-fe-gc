using System.ComponentModel.DataAnnotations;

namespace ex02.Models
{
    public class Asignado_A
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(8)]
        public required string CientificoDni { get; set; }

        [Required]
        [StringLength(4)]
        public required string ProyectoId { get; set; }

        public required Cientifico Cientifico { get; set; }

        public required Proyecto Proyecto { get; set; }
    }

}

