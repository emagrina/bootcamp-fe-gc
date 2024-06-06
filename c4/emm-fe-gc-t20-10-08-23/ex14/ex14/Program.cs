using System;

namespace ex14
{
    class ex14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el radio del circulo:");
            string radioStr = Console.ReadLine();

            if (double.TryParse(radioStr, out double radio))
            {
                double area = Math.PI * Math.Pow(radio, 2);
                Console.WriteLine($"El area del circulo con radio {radio} es: {area}");
            }
            else
            {
                Console.WriteLine("KO");
            }

        }
    }
}
