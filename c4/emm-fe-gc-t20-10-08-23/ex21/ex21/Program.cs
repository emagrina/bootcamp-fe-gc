using System;
namespace ex21
{
    class ex21
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
                    Console.WriteLine("Es un dia laboral.");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("No es un dia laboral.");
                    break;
                default:
                    Console.WriteLine("No ingresaste un dia valido de la semana.");
                    break;
            }

            Console.ReadLine();

        }
    }
}