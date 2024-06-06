using System;
using ClasesPersonas;

namespace ex04
{
    class PruebaPersona
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Persona persona2 = new Persona();

            Console.Write("Ingrese el nombre de la primera persona: ");
            string nombre1 = Console.ReadLine();
            persona1.SetNombre(nombre1);

            Console.Write("Ingrese el nombre de la segunda persona: ");
            string nombre2 = Console.ReadLine();
            persona2.SetNombre(nombre2);

            Console.WriteLine("\n");
            persona1.Saludar();
            persona2.Saludar();
        }
    }
}
