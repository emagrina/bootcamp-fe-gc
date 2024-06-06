using System;

namespace Milestone2
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valorDouble = 3.1415;

            int valorInt = (int)valorDouble;
            float valorFloat = (float)valorDouble;
            string valorString = valorDouble.ToString();

            Console.WriteLine($"Double: {valorDouble} - {valorDouble.GetType()}");
            Console.WriteLine($"Int: {valorInt} - {valorInt.GetType()}");
            Console.WriteLine($"Float: {valorFloat} - {valorFloat.GetType()}");
            Console.WriteLine($"String: {valorString} - {valorString.GetType()}");

        }

    }
}

