using System;

namespace ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[10];

            FillArray(numberArray);

            Console.WriteLine("Ver Array:");
            ShowArray(numberArray);

            Console.ReadLine();
        }

        static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}: {array[i]}");
            }
        }
    }
}
