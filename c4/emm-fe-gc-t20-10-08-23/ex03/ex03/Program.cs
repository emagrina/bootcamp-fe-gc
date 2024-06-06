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
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"Te llamas {nombre} y tienes {edad} años");
        }
    }
}