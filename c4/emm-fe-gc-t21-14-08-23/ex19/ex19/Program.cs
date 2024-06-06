namespace ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tamaño array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor min: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor max: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] primeArray = GenerateRandomArray(length, min, max);

            Console.WriteLine("Array:");
            ShowArray(primeArray);

            int maxPrime = FindMaxValue(primeArray);
            Console.WriteLine($"El numero primo mas grande es: {maxPrime}");

            Console.ReadLine();
        }

        static int[] GenerateRandomArray(int length, int min, int max)
        {
            Random random = new Random();
            int[] array = new int[length];
            int count = 0;

            while (count < length)
            {
                int randomNumber = random.Next(min, max + 1);

                if (IsPrime(randomNumber))
                {
                    array[count] = randomNumber;
                    count++;
                }
            }

            return array;
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}: {array[i]}");
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int FindMaxValue(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
