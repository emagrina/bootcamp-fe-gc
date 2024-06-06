using System;

namespace ClasesPersonas
{
    class Persona
    {
        private string nombre;

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}");
        }
    }
}
