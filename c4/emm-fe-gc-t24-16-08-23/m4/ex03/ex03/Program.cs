using System;
using System.Collections.Generic;
using Milestone1.Exceptions;

namespace Milestone3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Fase 1
            Console.WriteLine("FASE 1");

            int totalComida = 0;

            string[] menu = { "Pasta", "Pollo asado", "Paella" };
            int[] precio = { 10, 15, 20 };

            // Fase 2
            Console.WriteLine("\nFASE 2");
            List<int> comanda = new List<int>();
            int continuar = 1;

            while (continuar == 1)
            {
                try
                {
                    Console.WriteLine("Escoje tu plato:");
                    for (int i = 0; i < menu.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {menu[i]} - {precio[i]}€");
                    }
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion < 1 || opcion > menu.Length)
                    {
                        throw new PlatoInvalidoException("Plato inválido. Introduce un número válido.");
                    }

                    comanda.Add(opcion - 1);
                    totalComida += precio[opcion - 1];

                    Console.WriteLine("¿Quieres seguir comprando? (1: Si / 0: No)");
                    continuar = int.Parse(Console.ReadLine());

                    if (continuar != 0 && continuar != 1)
                    {
                        throw new TipoInvalidoException("Respuesta incorrecta. Introduce 1 para 'Si' o 0 para 'No'.");
                    }
                }
                catch (PlatoInvalidoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (TipoInvalidoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Fase 3
            Console.WriteLine("\nFASE 3");
            for (int i = 0; i < comanda.Count; i++)
            {
                int platoIndice = comanda[i];
                if (platoIndice >= 0 && platoIndice < menu.Length)
                {
                    Console.WriteLine($"{menu[platoIndice]} - {precio[platoIndice]}€");
                }
                else
                {
                    throw new PlatoComandaInvalidoException("Plato en la comanda inválido.");
                }
            }

            Console.WriteLine($"Total: {totalComida}€");
        }
    }
}
