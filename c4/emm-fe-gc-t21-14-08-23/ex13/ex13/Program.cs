namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el tamaño array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] array = GenerateRandomArray(length);

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i}: {array[i]}");
            }

            Console.ReadLine();
        }

        static int[] GenerateRandomArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(1, 11);
            }

            return array;
        }
    }
}
