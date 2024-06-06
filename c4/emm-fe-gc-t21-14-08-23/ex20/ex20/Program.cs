namespace ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tamaño array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] array1 = GenerateRandomArray(length);
            int[] array2 = array1;

            Console.WriteLine("Array1:");
            ShowArray(array1);

            Console.WriteLine("Array2:");
            ShowArray(array2);

            int[] resultArray = MultiplyArrays(array1, array2);

            Console.WriteLine("Resultado:");
            ShowArray(resultArray);

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

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}: {array[i]}");
            }
        }

        static int[] MultiplyArrays(int[] array1, int[] array2)
        {
            int[] resultArray = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                resultArray[i] = array1[i] * array2[i];
            }

            return resultArray;
        }
    }
}
