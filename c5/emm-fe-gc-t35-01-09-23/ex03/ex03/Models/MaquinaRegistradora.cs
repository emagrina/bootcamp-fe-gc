using System.ComponentModel.DataAnnotations;

namespace ex03.Models
{
	public class MaquinaRegistradora
	{
        [Key]
        public int Codigo { get; set; }

        public int Piso { get; set; }

        public ICollection<Venta>? Ventas { get; set; }
    }
}

