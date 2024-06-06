using System;

namespace ex03
{
    class Operaciones
    {
        private int valor1;
        private int valor2;

        public Operaciones(int valor1, int valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public int Sumar()
        {
            return valor1 + valor2;
        }

        public int Restar()
        {
            return valor1 - valor2;
        }

        public int Multiplicar()
        {
            return valor1 * valor2;
        }

        public double Dividir()
        {
            if (valor2 != 0)
            {
                return (double)valor1 / valor2;
            }
            else
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Primer valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Operaciones operaciones = new Operaciones(valor1, valor2);

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Suma: {operaciones.Sumar()}");
            Console.WriteLine($"Resta: {operaciones.Restar()}");
            Console.WriteLine($"Multiplicación: {operaciones.Multiplicar()}");

            try
            {
                Console.WriteLine($"División: {operaciones.Dividir()}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
