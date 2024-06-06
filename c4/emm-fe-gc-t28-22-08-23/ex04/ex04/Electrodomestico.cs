using System;
namespace ex04
{
    public class Electrodomestico
    {
        protected double precioBase;
        protected string color;
        protected char consumoEnergetico;
        protected double peso;

        protected const string COLOR_DEFAULT = "blanco";
        protected const char CONSUMO_ENERGETICO_DEFAULT = 'F';
        protected const double PRECIO_BASE_DEFAULT = 100;
        protected const double PESO_DEFAULT = 5;

        public Electrodomestico()
        {
            color = COLOR_DEFAULT;
            consumoEnergetico = CONSUMO_ENERGETICO_DEFAULT;
            precioBase = PRECIO_BASE_DEFAULT;
            peso = PESO_DEFAULT;
        }

        public Electrodomestico(double precioBase, double peso)
        {
            color = COLOR_DEFAULT;
            consumoEnergetico = CONSUMO_ENERGETICO_DEFAULT;
            this.precioBase = precioBase;
            this.peso = peso;
        }

        public Electrodomestico(double precioBase, string color, char consumoEnergetico, double peso)
        {
            this.precioBase = precioBase;
            this.color = ComprobarColor(color);
            this.consumoEnergetico = ComprobarConsumoEnergetico(consumoEnergetico);
            this.peso = peso;
        }

        public double GetPrecioBase()
        {
            return precioBase;
        }

        public string GetColor()
        {
            return color;
        }

        public char GetConsumoEnergetico()
        {
            return consumoEnergetico;
        }

        public double GetPeso()
        {
            return peso;
        }

        private static char ComprobarConsumoEnergetico(char letra)
        {
            if ("ABCDEF".Contains(char.ToUpper(letra)))
            {
                return char.ToUpper(letra);
            }
            return CONSUMO_ENERGETICO_DEFAULT;
        }

        private static string ComprobarColor(string color)
        {
            string[] coloresDisponibles = { "blanco", "negro", "rojo", "azul", "gris" };
            if (coloresDisponibles.Contains(color.ToLower()))
            {
                return color.ToLower();
            }
            return COLOR_DEFAULT;
        }

        public virtual double PrecioFinal()
        {
            double precio = precioBase;

            switch (consumoEnergetico)
            {
                case 'A':
                    precio += 100;
                    break;
                case 'B':
                    precio += 80;
                    break;
                case 'C':
                    precio += 60;
                    break;
                case 'D':
                    precio += 50;
                    break;
                case 'E':
                    precio += 30;
                    break;
                case 'F':
                    precio += 10;
                    break;
            }

            if (peso >= 0 && peso < 20)
            {
                precio += 10;
            }
            else if (peso >= 20 && peso < 50)
            {
                precio += 50;
            }
            else if (peso >= 50 && peso < 80)
            {
                precio += 80;
            }
            else if (peso >= 80)
            {
                precio += 100;
            }

            return precio;
        }
    }
}

