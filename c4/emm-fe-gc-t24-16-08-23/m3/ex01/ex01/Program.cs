namespace Milestone1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte 6 ciudades:");
            string[] ciudades = new string[6];

            for (int i = 0; i < ciudades.Length; i++)
            {
                Console.Write($"{i + 1}: ");
                ciudades[i] = Console.ReadLine();
            }

            // Fase 1
            Console.WriteLine("\nFASE 1");
            foreach (string ciudad in ciudades)
            {
                Console.WriteLine(ciudad);
            }

            // Fase 2
            Console.WriteLine("\nFASE 2");
            Array.Sort(ciudades);

            foreach (string ciudad in ciudades)
            {
                Console.WriteLine(ciudad);
            }

            // Fase 3
            Console.WriteLine("\nFASE 3");
            string[] ciudadesModificadas = new string[6];

            for (int i = 0; i < ciudades.Length; i++)
            {
                ciudadesModificadas[i] = ciudades[i].Replace('a', '4');
            }

            Array.Sort(ciudadesModificadas);

            foreach (string ciudad in ciudadesModificadas)
            {
                Console.WriteLine(ciudad);
            }

            // Fase 4
            Console.WriteLine("\nFASE 4");
            string[][] arraysCiudadesInvertidos = new string[ciudades.Length][];

            for (int i = 0; i < ciudades.Length; i++)
            {
                arraysCiudadesInvertidos[i] = new string[ciudades[i].Length];
                for (int j = 0; j < ciudades[i].Length; j++)
                {
                    arraysCiudadesInvertidos[i][j] = ciudades[i][ciudades[i].Length - 1 - j].ToString();
                }
            }

            foreach (string[] arrayCiudad in arraysCiudadesInvertidos)
            {
                string ciudadInvertida = string.Join("", arrayCiudad);
                Console.WriteLine(ciudadInvertida);
            }
        }
    }
}
