using System;

namespace Milestone3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOrigin = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Array original:");
            PrintArray(arrayOrigin);

            int temp = arrayOrigin[arrayOrigin.Length - 1];
            for (int i = arrayOrigin.Length - 1; i > 0; i--)
            {
                arrayOrigin[i] = arrayOrigin[i - 1];
            }
            arrayOrigin[0] = temp;

            Console.WriteLine("\nArray rotado:");
            PrintArray(arrayOrigin);
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

        }
    }
}
