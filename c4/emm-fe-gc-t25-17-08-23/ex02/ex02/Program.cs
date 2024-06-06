using System;

namespace ex02
{
    class Empleado
    {
        private string nombre;
        private double sueldo;

        public Empleado(string nombre, double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Sueldo: {sueldo:C}");
        }

        public void VerificarImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado debe pagar impuestos.");
            }
            else
            {
                Console.WriteLine("El empleado no debe pagar impuestos.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Sueldo empleado: ");
            double sueldo = double.Parse(Console.ReadLine());

            Empleado empleado = new Empleado(nombre, sueldo);

            Console.WriteLine("\nDatos empleado:");
            empleado.ImprimirDatos();
            empleado.VerificarImpuestos();
        }
    }
}
