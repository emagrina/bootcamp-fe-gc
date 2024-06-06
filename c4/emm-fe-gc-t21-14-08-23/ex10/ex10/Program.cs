using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Que tabla quieres: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            Console.ReadLine();
        }
    }
}
