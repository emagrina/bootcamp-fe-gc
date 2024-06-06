namespace ex19
{
    class ex19
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++)
            {
                if (num % 2 == 0 && num % 3 == 0)
                {
                    Console.WriteLine(num);
                }
            }

            Console.ReadLine();
        }
    }
}
