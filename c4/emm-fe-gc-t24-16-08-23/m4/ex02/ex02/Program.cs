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
                Console.WriteLine("Escoje tu plato:");
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menu[i]} - {precio[i]}€");
                }
                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > menu.Length)
                {
                    throw new ArgumentException("Opción incorrecta. Introduce un número válido.");
                }

                comanda.Add(opcion - 1);
                totalComida += precio[opcion - 1];

                Console.WriteLine("¿Quieres seguir comprando? (1: Si / 0: No)");
                if (!int.TryParse(Console.ReadLine(), out continuar) || (continuar != 0 && continuar != 1))
                {
                    throw new ArgumentException("Respuesta incorrecta. Introduce 1 para 'Si' o 0 para 'No'.");
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
            }

            Console.WriteLine($"Total: {totalComida}€");
        }
    }
}
