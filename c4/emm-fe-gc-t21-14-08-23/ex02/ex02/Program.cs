namespace ex02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero min: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Numero max: ");
            int max = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad numeros a generar: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numeros generados entre el {min} y {max}:");
            GenerateRandomNumbers(min, max, count);

            Console.ReadLine();
        }

        static void GenerateRandomNumbers(int min, int max, int count)
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                int randomNumber = random.Next(min, max + 1);
                Console.WriteLine(randomNumber);
            }
        }
    }
}

