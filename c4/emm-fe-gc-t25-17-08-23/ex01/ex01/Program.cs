using System;

namespace ex01
{
    class Alumno
    {
        private string nombre;
        private int edad;

        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
        }

        public void VerificarEdad()
        {
            Console.WriteLine((edad >= 18) ? "El alumno es mayor de edad." : "El alumno no es mayor de edad.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre alumno: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad alumno: ");
            int edad = int.Parse(Console.ReadLine());

            Alumno alumno = new Alumno(nombre, edad);

            Console.WriteLine("\nDatos alumno:");
            alumno.ImprimirDatos();
            alumno.VerificarEdad();
        }
    }
}
