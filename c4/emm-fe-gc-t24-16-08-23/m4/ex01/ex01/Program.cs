namespace Milestone1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Fase 1
            Console.WriteLine("FASE 1");

            int billete5 = 5;
            int billete10 = 10;
            int billete20 = 20;
            int billete50 = 50;
            int billete100 = 100;
            int billete200 = 200;
            int billete500 = 500;

            int totalComida = 0;

            string[] menu = { "Pasta", "Pollo asado", "Paella" };
            int[] precio = { 10, 15, 20 };

            // Fase 2
            Console.WriteLine("\nFASE 1");
            List<int> comanda = new List<int>();
            int continuar = 1;

            while (continuar == 1)
            {
                Console.WriteLine("Escoje tu plato:");
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menu[i]} - {precio[i]}€");
                }
                int opcion = int.Parse(Console.ReadLine());

                if (opcion >= 1 && opcion <= menu.Length)
                {
                    comanda.Add(opcion - 1);
                    totalComida += precio[opcion - 1];
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta.");
                }

                Console.WriteLine("Quieres seguir comprando? (1: Si / 0: No)");
                continuar = int.Parse(Console.ReadLine());
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
