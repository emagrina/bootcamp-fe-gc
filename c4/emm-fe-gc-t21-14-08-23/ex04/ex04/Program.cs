using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un numero: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = CalculateFactorial(number);

            Console.WriteLine($"{number}! = {factorial}");

            Console.ReadLine();
        }

        static int CalculateFactorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("El numero debe ser natural.");
            }

            if (num == 0 || num == 1)
            {
                return 1;
            }

            int result = 1;

            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
