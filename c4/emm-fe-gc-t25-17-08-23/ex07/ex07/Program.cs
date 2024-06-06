using System;

namespace ex07
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string DNI;
        private char sexo;
        private double peso;
        private double altura;

        public const char SexoHombre = 'H';
        public const char SexoMujer = 'M';

        public Persona()
        {
            nombre = "";
            edad = 0;
            sexo = SexoHombre;
            DNI = GenerarDNI();
            peso = 0;
            altura = 0;
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = ValidarSexo(sexo);
            DNI = GenerarDNI();
            peso = 0;
            altura = 0;
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = ValidarSexo(sexo);
            DNI = GenerarDNI();
            this.peso = peso;
            this.altura = altura;
        }

        private char ValidarSexo(char sexo)
        {
            if (sexo == SexoHombre || sexo == SexoMujer)
            {
                return sexo;
            }
            else
            {
                return SexoHombre;
            }
        }

        private string GenerarDNI()
        {
            Random random = new Random();
            int numeroDNI = random.Next(10000000, 99999999);
            char letraDNI = (char)(random.Next(26) + 'A');
            return $"{numeroDNI}{letraDNI}";
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Información de la persona:");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"DNI: {DNI}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Peso: {peso} kg");
            Console.WriteLine($"Altura: {altura} cm");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Persona persona2 = new Persona("Elizabeth", 17, Persona.SexoMujer);
            Persona persona3 = new Persona("Ramon", 30, Persona.SexoHombre, 75.5, 175);

            persona1.MostrarInformacion();
            Console.WriteLine();
            persona2.MostrarInformacion();
            Console.WriteLine();
            persona3.MostrarInformacion();
        }
    }
}
