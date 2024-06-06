namespace ex03
{
    class ex03
    {
        static void Main(string[] args)
        {

            int x = 3;
            int y = 2;

            double n = 6.5;
            double m = 2.10;

            Console.WriteLine("El valor de cada variable:");

            Console.WriteLine("La suma " + (x + y));
            Console.WriteLine("La diferencia " + (x - y));
            Console.WriteLine("El producto " + (x * y));
            Console.WriteLine("El cociente " + (x / y));
            Console.WriteLine("El resto " + (x % y));

            Console.WriteLine("La suma " + (n + m));
            Console.WriteLine("La diferencia " + (n - m));
            Console.WriteLine("El producto " + (n * m));
            Console.WriteLine("El cociente " + (n / m));
            Console.WriteLine("El resto " + (n % m));

            Console.WriteLine("La suma " + (x + n));
            Console.WriteLine("El cociente " + (y / m));
            Console.WriteLine("El resto " + (y % m));

            Console.Write("La suma de todas las variables: ");
            Console.WriteLine(x * y * n * m);

        }
    }
}