namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[10];

            Console.WriteLine("Ingresa los valores al array: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}: ");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = CalculateArraySum(numberArray);
            double average = CalculateArrayAverage(sum, numberArray.Length);

            Console.WriteLine($"Media: {average}");

            Console.ReadLine();
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

        static double CalculateArrayAverage(int sum, int count)
        {
            return (double)sum / count;
        }
    }
}
