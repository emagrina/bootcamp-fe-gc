using System;

namespace ex05
{
    class Libro
    {
        private string autor;
        private string titulo;
        private string ubicacion;

        public string GetAutor()
        {
            return autor;
        }

        public void SetAutor(string nuevoAutor)
        {
            autor = nuevoAutor;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string nuevoTitulo)
        {
            titulo = nuevoTitulo;
        }

        public string GetUbicacion()
        {
            return ubicacion;
        }

        public void SetUbicacion(string nuevaUbicacion)
        {
            ubicacion = nuevaUbicacion;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();
            libro.SetAutor(autor);

            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();
            libro.SetTitulo(titulo);

            Console.Write("Ingrese la ubicación del libro: ");
            string ubicacion = Console.ReadLine();
            libro.SetUbicacion(ubicacion);

            Console.WriteLine("\nInformación del libro:");
            Console.WriteLine($"Autor: {libro.GetAutor()}");
            Console.WriteLine($"Título: {libro.GetTitulo()}");
            Console.WriteLine($"Ubicación: {libro.GetUbicacion()}");
        }
    }
}
