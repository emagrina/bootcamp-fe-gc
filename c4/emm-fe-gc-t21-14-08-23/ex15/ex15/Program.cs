namespace ex15
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

            int[] reversedArray = ReverseArray(array);

            Console.WriteLine("Contenido del array invertido:");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i}: {reversedArray[i]}");
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

        static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[array.Length - 1 - i] = array[i];
            }

            return reversedArray;
        }
    }
}
