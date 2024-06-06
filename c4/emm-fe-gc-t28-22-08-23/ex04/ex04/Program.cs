namespace ex04
{
    class Program
    {
        static void Main()
        {
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];

            electrodomesticos[0] = new Lavadora(300, 20);
            electrodomesticos[1] = new Television(50, true, 600, "negro", 'B', 40);
            electrodomesticos[2] = new Lavadora(400, 25);
            electrodomesticos[3] = new Television(42, false, 500, "rojo", 'A', 32);
            electrodomesticos[4] = new Lavadora(350, 22);
            electrodomesticos[5] = new Television(60, true, 700, "azul", 'C', 50);
            electrodomesticos[6] = new Lavadora(250, 18);
            electrodomesticos[7] = new Television(32, false, 450, "gris", 'E', 28);
            electrodomesticos[8] = new Electrodomestico(200, "blanco", 'D', 15);
            electrodomesticos[9] = new Electrodomestico(180, "negro", 'F', 12);

            double precioTotalElectrodomesticos = 0;
            double precioTotalLavadoras = 0;
            double precioTotalTelevisiones = 0;

            foreach (Electrodomestico electrodomestico in electrodomesticos)
            {
                double precioFinal = electrodomestico.PrecioFinal();
                precioTotalElectrodomesticos += precioFinal;

                if (electrodomestico is Lavadora lavadora)
                {
                    precioTotalLavadoras += precioFinal;
                }
                else if (electrodomestico is Television television)
                {
                    precioTotalTelevisiones += precioFinal;
                }

                Console.WriteLine($"Precio final: {precioFinal}");
            }

            Console.WriteLine($"Precio total lavadoras: {precioTotalLavadoras}");
            Console.WriteLine($"Precio total televisiones: {precioTotalTelevisiones}");
            Console.WriteLine($"Precio total electrodomesticos: {precioTotalElectrodomesticos}");
        }
    }
}

