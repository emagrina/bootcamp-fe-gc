using System;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un numero entero: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int digitCount = CountDigits(number);
            Console.WriteLine($"El numero {number} tiene {digitCount} cifras.");

            Console.ReadLine();
        }

        static int CountDigits(int num)
        {
            if (num == 0)
            {
                return 1; 
            }

            int count = 0;

            while (num != 0)
            {
                num /= 10;
                count++;
            }

            return count;
        }
    }
}
