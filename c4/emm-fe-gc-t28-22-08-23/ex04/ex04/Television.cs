using System;
namespace ex04
{
    public class Television : Electrodomestico
    {
        private readonly int resolucion;
        private readonly bool sintonizadorTDT;

        private const int RESOLUCION_DEFAULT = 20;

        public Television() : base()
        {
            resolucion = RESOLUCION_DEFAULT;
            sintonizadorTDT = false;
        }

        public Television(double precioBase, double peso) : base(precioBase, peso)
        {
            resolucion = RESOLUCION_DEFAULT;
            sintonizadorTDT = false;
        }

        public Television(int resolucion, bool sintonizadorTDT, double precioBase, string color, char consumoEnergetico, double peso)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public int GetResolucion()
        {
            return resolucion;
        }

        public bool GetSintonizadorTDT()
        {
            return sintonizadorTDT;
        }

        public override double PrecioFinal()
        {
            double precio = base.PrecioFinal();

            if (resolucion > 40)
            {
                precio += precioBase * 0.3;
            }

            if (sintonizadorTDT)
            {
                precio += 50;
            }

            return precio;
        }
    }
}

