namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tamaño array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] numberArray = new int[length];

            FillArray(numberArray, 0, 9);

            Console.WriteLine("Array:");
            ShowArray(numberArray);

            int sum = CalculateArraySum(numberArray);
            Console.WriteLine($"Total: {sum}");

            Console.ReadLine();
        }

        static void FillArray(int[] array, int minValue, int maxValue)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerateRandomNumber(random, minValue, maxValue);
            }
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}: {array[i]}");
            }
        }

        static int CalculateArraySum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        private static int GenerateRandomNumber(Random random, int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
        }
    }
}
