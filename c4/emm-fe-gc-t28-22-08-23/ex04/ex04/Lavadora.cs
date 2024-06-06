using System;
namespace ex04
{
    public class Lavadora : Electrodomestico
    {
        private readonly double carga;

        private const double CARGA_DEFAULT = 5;

        public Lavadora() : base()
        {
            carga = CARGA_DEFAULT;
        }

        public Lavadora(double precioBase, double peso) : base(precioBase, peso)
        {
            carga = CARGA_DEFAULT;
        }

        public Lavadora(double carga, double precioBase, string color, char consumoEnergetico, double peso)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public double GetCarga()
        {
            return carga;
        }

        public override double PrecioFinal()
        {
            double precio = base.PrecioFinal();

            if (carga > 30)
            {
                precio += 50;
            }

            return precio;
        }
    }
}

