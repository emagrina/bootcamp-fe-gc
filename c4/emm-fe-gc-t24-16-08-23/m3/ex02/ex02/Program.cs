using System;

namespace Milestone2
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] notas = new double[5, 3];
            string[] nombresAlumnos = { "Minerva Tello", "Saturnino Betancor", "Celso Fuentes", "Gaspar Portillo", "Paulina Mejia" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Introduce las notas de {nombresAlumnos[i]}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Nota {j + 1}: ");
                    notas[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nResultados:");
            for (int i = 0; i < 5; i++)
            {
                double promedio = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
                Console.Write($"{nombresAlumnos[i]} - Notas: {notas[i, 0]}, {notas[i, 1]}, {notas[i, 2]} - ");

                Console.WriteLine($"Promedio: {promedio:F2} - {(promedio >= 5 ? "Aprobado" : "Suspendido")}");
            }
        }
    }
}
