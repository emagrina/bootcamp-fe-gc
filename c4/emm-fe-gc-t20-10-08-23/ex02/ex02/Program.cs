using System;

namespace ex02
{
    class ex02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre persona:");
            String nombre = Console.ReadLine();

            Console.WriteLine("Nombre ciudad:");
            String ciudad = Console.ReadLine();

            Console.WriteLine($"Hola {nombre} bienvenido a {ciudad}");
        }
    }
}