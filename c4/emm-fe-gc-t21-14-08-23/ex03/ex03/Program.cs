namespace ex03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un numero: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPrimeNumber(number))
            {
                Console.WriteLine($"{number} es primo.");
            }
            else
            {
                Console.WriteLine($"{number} no es primo.");
            }

            Console.ReadLine();
        }

        static bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            if (num <= 3)
            {
                return true;
            }

            if (num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

