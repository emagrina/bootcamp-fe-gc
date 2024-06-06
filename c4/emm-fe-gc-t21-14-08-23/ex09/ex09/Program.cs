using System;

namespace ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el tamaño array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] numberArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Valor posición {i}: ");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array:");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i}: {numberArray[i]}");
            }

            Console.ReadLine();
        }
    }
}
