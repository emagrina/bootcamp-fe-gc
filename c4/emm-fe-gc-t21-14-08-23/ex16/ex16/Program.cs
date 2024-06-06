namespace ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el tamano del array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool isPalindrome = IsArrayPalindrome(array);

            if (isPalindrome)
            {
                Console.WriteLine("capicua = true");
            }
            else
            {
                Console.WriteLine("capicua = false");
            }

            Console.ReadLine();
        }

        static bool IsArrayPalindrome(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
