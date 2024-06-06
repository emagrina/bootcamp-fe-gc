using System;
using ex09;

namespace CineApp
{
    class Program
    {
        static void Main()
        {
            Pelicula pelicula = new()
            {
                Titulo = "Oppenheimer",
                Duracion = 180,
                EdadMinima = 17,
                Director = "Christopher Nolan"
            };

            Cine cine = new(pelicula, 10, 8, 9);

            Random random = new();

            for (int i = 0; i < 50; i++)
            {
                Espectador espectador = new()
                {
                    Nombre = "Espectador " + (i + 1),
                    Edad = random.Next(5, 60),
                    Dinero = random.Next(0, 100)
                };

                if (cine.HayAsientosDisponibles())
                {
                    if (cine.SentarEspectador(espectador))
                    {
                        Console.WriteLine($"{espectador.Nombre}, Edad: {espectador.Edad}, Dinero: {espectador.Dinero} se ha sentado.");
                    }
                    else
                    {
                        Console.WriteLine($"{espectador.Nombre}, Edad: {espectador.Edad}, Dinero: {espectador.Dinero} no cumple los requisitos.");
                    }
                }
                else
                {
                    Console.WriteLine($"No hay asientos disponibles.");
                }
            }

            cine.MostrarAsientos();
        }
    }
}
