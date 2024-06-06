using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ex01.Models
{
	public class Suministra
	{
        [Key]
        [Column(Order = 0)]
        public int CodigoPieza { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public required string IdProveedor { get; set; }

        public double Precio { get; set; }

        public required Pieza Pieza { get; set; }
        public required Proveedor Proveedor { get; set; }
    }
}

