using System;
namespace Milestone1
{
	public class Program
	{
        static void Main(string[] args)
        {
            // Fase 1
            Console.WriteLine("\nFASE 1");

            string nombre = "Juan";
            string apellido1 = "Perez";
            string apellido2 = "Gonzalez";

            int dia = 01;
            int mes = 01;
            int ano = 1979;

            Console.WriteLine($"{apellido1} {apellido2}, {nombre}");
            Console.WriteLine($"{dia}/{mes}/{ano}");

            // Fase 2
            Console.WriteLine("\nFASE 2");

            const int AnoBisiesto = 1948;
            const int IntervaloAnosBisiestos = 4;

            int anoBisiesto = (ano - AnoBisiesto) / IntervaloAnosBisiestos;

            Console.WriteLine($"Entre {AnoBisiesto} y {ano} hay {anoBisiesto} años en total");

            // Fase 3
            Console.WriteLine("\nFASE 3");

            bool esAnoNacimientoBisiesto = (ano % IntervaloAnosBisiestos) == 0;
            
            string fraseBisiesto = "El año de nacimiento es un año bisiesto.";
            string fraseNoBisiesto = "El año de nacimiento es un año bisiesto.";

            Console.WriteLine(esAnoNacimientoBisiesto ? fraseBisiesto : fraseNoBisiesto);

            Console.WriteLine("Años bisiestos hasta el año de nacimiento:");
            for (int anoNum = AnoBisiesto; anoNum <= ano; anoNum += IntervaloAnosBisiestos)
            {
                if (DateTime.IsLeapYear(anoNum))
                {
                    Console.WriteLine(anoNum);
                }

            }

            // Fase 4
            Console.WriteLine("\nFASE 4");

            string nombreCompleto = $"{nombre} {apellido1} {apellido2}";
            string fechaNacimiento = $"{dia:D2}/{mes:D2}/{ano}";

            Console.WriteLine($"Mi nombre es {nombreCompleto}");
            Console.WriteLine($"Naci en el año {fechaNacimiento}");

            Console.WriteLine(esAnoNacimientoBisiesto ? fraseBisiesto : fraseNoBisiesto);

        }

    }
}

