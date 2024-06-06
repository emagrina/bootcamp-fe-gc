using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ex15
{
    class ex15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"El numero {num} es divisible entre 2.");
            }
            else
            {
                Console.WriteLine($"El numero {num} no es divisible entre 2.");
            }

        }
    }
}
