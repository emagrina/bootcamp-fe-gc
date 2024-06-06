namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el tamano del array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] array = GenerateRandomArray(length);

            Console.WriteLine("Contenido del array:");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i}: {array[i]}");
            }

            Console.Write("Busa en el array: ");
            int numberToSearch = Convert.ToInt32(Console.ReadLine());

            bool exists = SearchNumber(array, numberToSearch);

            if (exists)
            {
                Console.WriteLine($"El {numberToSearch} existe");
            }
            else
            {
                Console.WriteLine($"El {numberToSearch} no existe");
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

        static bool SearchNumber(int[] array, int number)
        {
            foreach (int item in array)
            {
                if (item == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
