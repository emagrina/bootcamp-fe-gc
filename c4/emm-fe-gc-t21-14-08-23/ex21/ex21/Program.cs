namespace ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tamaño array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] originalArray = GenerateRandomArray(length);

            int lastDigit = GetValidLastDigit();

            Console.WriteLine($"Ultimo digito {lastDigit}:");
            int[] filteredArray = FilterArray(originalArray, lastDigit);
            ShowArray(filteredArray);

            Console.ReadLine();
        }

        static int[] GenerateRandomArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(1, 301);
            }

            return array;
        }

        static int GetValidLastDigit()
        {
            int digit;
            while (true)
            {
                Console.Write("Introduce un digito(0-9): ");
                if (int.TryParse(Console.ReadLine(), out digit) && digit >= 0 && digit <= 9)
                {
                    return digit;
                }
            }
        }

        static int[] FilterArray(int[] array, int lastDigit)
        {
            int[] filteredArray = new int[array.Length];
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 10 == lastDigit)
                {
                    filteredArray[count] = array[i];
                    count++;
                }
            }

            Array.Resize(ref filteredArray, count);
            return filteredArray;
        }

        static void ShowArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}