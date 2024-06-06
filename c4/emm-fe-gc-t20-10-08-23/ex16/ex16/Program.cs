namespace ex16
{
    class ex16
    {
        static void Main(string[] args)
        {
            const double IVAPorcentaje = 0.21;

            Console.WriteLine("Ingrese un numero:");
            double precio = double.Parse(Console.ReadLine());

            double precioConIVA = precio * (1 + IVAPorcentaje);
            Console.WriteLine($"El precio con IVA es: {precioConIVA:N2}");


        }
    }
}
