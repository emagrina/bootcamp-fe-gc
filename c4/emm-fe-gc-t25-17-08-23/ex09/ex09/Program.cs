using System;

namespace ClasesElectrodomestico
{
    enum Color
    {
        Blanco,
        Negro,
        Rojo,
        Azul,
        Gris
    }

    class Electrodomestico
    {
        protected double precioBase;
        protected Color color;
        protected char consumoEnergetico;
        protected double peso;

        public const char ConsumoEnergeticoDefault = 'F';

        public Electrodomestico()
        {
            precioBase = 100;
            color = Color.Blanco;
            consumoEnergetico = ConsumoEnergeticoDefault;
            peso = 5;
        }

        public Electrodomestico(double precio, double peso)
        {
            precioBase = precio;
            color = Color.Blanco;
            consumoEnergetico = ConsumoEnergeticoDefault;
            this.peso = peso;
        }

        public Electrodomestico(double precio, Color color, char consumoEnergetico, double peso)
        {
            precioBase = precio;
            EstablecerColor(color);
            EstablecerConsumoEnergetico(consumoEnergetico);
            this.peso = peso;
        }

        private void EstablecerColor(Color color)
        {
            this.color = color;
        }

        private void EstablecerConsumoEnergetico(char consumo)
        {
            char consumoUpperCase = char.ToUpper(consumo);

            if (consumoUpperCase >= 'A' && consumoUpperCase <= 'F')
            {
                consumoEnergetico = consumoUpperCase;
            }
            else
            {
                consumoEnergetico = ConsumoEnergeticoDefault;
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Información del electrodomestico:");
            Console.WriteLine($"Precio Base: {precioBase} €");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Consumo Energético: {consumoEnergetico}");
            Console.WriteLine($"Peso: {peso} kg");
        }
    }

    class Program
    {
        static void Main()
        {
            Electrodomestico electrodomestico1 = new ();
            Electrodomestico electrodomestico2 = new (250, 10);
            Electrodomestico electrodomestico3 = new (300, Color.Rojo, 'C', 15);

            Console.WriteLine("Electrodomestico 1:");
            electrodomestico1.MostrarInformacion();

            Console.WriteLine("\nElectrodomestico 2:");
            electrodomestico2.MostrarInformacion();

            Console.WriteLine("\nElectrodomestico 3:");
            electrodomestico3.MostrarInformacion();
        }
    }
}
