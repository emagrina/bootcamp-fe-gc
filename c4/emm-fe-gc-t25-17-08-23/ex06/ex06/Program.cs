using System;

namespace ex06
{
    class Coche
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private double potencia;

        public Coche(string marca, string modelo, int cilindrada, double potencia)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
            this.potencia = potencia;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Información del coche:");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Cilindrada: {cilindrada} cc");
            Console.WriteLine($"Potencia: {potencia} HP");
        }

        static void Main(string[] args)
        {
            Coche coche = new Coche("Ford", "Mustang", 5000, 450.75);
            coche.MostrarInformacion();
        }
    }
}
