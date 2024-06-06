using System;

namespace Milestone3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el rango: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci:");
            for (int i = 0; i <= n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
