using System;

namespace ex05
{
    class ex05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un día de la semana:");
            string dia = Console.ReadLine();

            switch (dia.ToLower())
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana.");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Es fin de semana.");
                    break;
                default:
                    Console.WriteLine("No ingresaste un día válido de la semana.");
                    break;
            }

            Console.ReadLine();

        }
    }
}