using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex02.Models
{
    public class Cliente
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(250)]
        public string? Apellido { get; set; }

        [Required]
        [StringLength(250)]
        public string? Direccion { get; set; }

        [Required]
        public int? Dni { get; set; }

        [Required]
        public DateTime? Fecha { get; set; }

        public ICollection<Video>? Videos { get; set; }
    }
}
