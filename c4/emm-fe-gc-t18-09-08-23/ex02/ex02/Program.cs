using System;

namespace ConsoleAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            double num3 = 2.57;

            double suma = num1 + num3;
            Console.WriteLine(suma);

            Console.WriteLine("El numero introducido es: " + Convert.ToInt32(Console.ReadLine()));

            Console.ReadKey();
        }
    }
}