
namespace ex07
{
    public class Raices
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void ObtenerRaices()
        {
            double discriminante = GetDiscriminante();

            if (discriminante >= 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine($"Solucion 1: {x1}");
                Console.WriteLine($"Solucion 2: {x2}");
            }
            else
            {
                Console.WriteLine("No hay soluciones reales.");
            }
        }

        public void ObtenerRaiz()
        {
            double discriminante = GetDiscriminante();

            if (discriminante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Única solución: {x}");
            }
            else
            {
                Console.WriteLine("No hay una única solución.");
            }
        }

        public double GetDiscriminante()
        {
            return (b * b) - (4 * a * c);
        }

        public bool TieneRaices()
        {
            double discriminante = GetDiscriminante();
            return discriminante >= 0;
        }

        public bool TieneRaiz()
        {
            double discriminante = GetDiscriminante();
            return discriminante == 0;
        }

        public void Calcular()
        {
            if (TieneRaices())
            {
                ObtenerRaices();
            }
            else if (TieneRaiz())
            {
                ObtenerRaiz();
            }
            else
            {
                Console.WriteLine("No hay soluciones reales.");
            }
        }
    }
}
