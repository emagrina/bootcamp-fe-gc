using System;

namespace Milestone2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introduce la altura: ");
            int altura = int.Parse(Console.ReadLine());

            // Fase 1
            Console.WriteLine("FASE 1: \n");
            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }

            // Fase 2
            Console.WriteLine("\nFASE 2: \n");
            for (int i = altura; i >= 1; i--)
            {
                for (int j = 1; j <= altura - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
