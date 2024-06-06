using System;

namespace ArrayPositionValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el tamaño el array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] numberArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                numberArray[i] = i;
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
