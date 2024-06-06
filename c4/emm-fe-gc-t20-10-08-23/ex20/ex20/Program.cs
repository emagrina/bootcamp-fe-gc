namespace ex20
{
    class ex20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de ventas:");
            int numeroVentas = int.Parse(Console.ReadLine());

            double sumaVentas = 0;

            for (int num = 1; num <= numeroVentas; num++)
            {
                Console.Write($"Ingrese la venta {num}: ");
                sumaVentas += double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Total: {sumaVentas} €");

            Console.ReadLine();
        }
    }
}
