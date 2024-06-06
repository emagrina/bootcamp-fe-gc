namespace ex11
{
    class ex11
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            if (num1 > num2)
            {
                Console.WriteLine($"El numero {num1} es mayor que {num2}.");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"El numero {num2} es mayor que {num1}.");
            }
            else
            {
                Console.WriteLine("Los numeros son iguales.");
            }
        }
    }
}