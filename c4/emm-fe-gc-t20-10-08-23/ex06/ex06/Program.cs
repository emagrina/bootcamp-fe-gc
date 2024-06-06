using System;

namespace ex06
{
    class ex06
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el precio:");
            if (double.TryParse(Console.ReadLine(), out double precio) && precio > 0)
            {
                Console.WriteLine("Ingrese la forma de pago (efectivo o tarjeta):");
                string formaPago = Console.ReadLine().ToLower();

                switch (formaPago.ToLower())
                {
                    case "efectivo":
                        Console.WriteLine($"El precio total es {precio} €");
                        break;
                    case "tarjeta":
                        Console.WriteLine("Introduce el numero de cuenta");
                        string numeroCuenta = Console.ReadLine();
                        Console.WriteLine($"El precio total es {precio} € al numero de cuenta {numeroCuenta}");
                        break;

                    default:
                        Console.WriteLine("Forma de pago no valida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un precio válido (valor positivo).");
            }

            Console.ReadLine();

        }
    }
}