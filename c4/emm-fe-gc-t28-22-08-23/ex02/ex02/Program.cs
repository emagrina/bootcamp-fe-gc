using ex02;

namespace ex02
{
    class Program
    {
        static void Main()
        {
            Persona persona1 = CrearPersonaConsola();
            Persona persona2 = new("Daniel Lorenzo", 25, 'H');
            persona2.SetPeso(60);
            persona2.SetAltura(1.65);
            Persona persona3 = new();

            MostrarPersona(persona1);
            MostrarPersona(persona2);
            MostrarPersona(persona3);
        }

        static Persona CrearPersonaConsola()
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese sexo (H/M): ");
            char sexo = char.Parse(Console.ReadLine());

            Console.Write("Ingrese peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Ingrese altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            return new Persona(nombre, edad, sexo, peso, altura);
        }

        static void MostrarPersona(Persona persona)
        {
            Console.WriteLine(persona.ToString());
            int imc = persona.CalcularIMC();
            if (imc == Persona.IMC_DEBAJO_PESO_IDEAL)
            {
                Console.WriteLine("Esta por debajo del peso ideal.");
            }
            else if (imc == Persona.IMC_PESO_IDEAL)
            {
                Console.WriteLine("Peso ideal.");
            }
            else
            {
                Console.WriteLine("Tiene sobrepeso.");
            }

            if (persona.EsMayorDeEdad())
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("No es mayor de edad.");
            }

            Console.WriteLine();
        }
    }
}
