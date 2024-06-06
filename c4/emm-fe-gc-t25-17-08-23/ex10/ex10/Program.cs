using System;

namespace ClasesSerie
{
    class Serie
    {
        private readonly string titulo;
        private readonly int numeroTemporadas;
        private bool entregado;
        private readonly string genero;
        private readonly string creador;

        public Serie()
        {
            titulo = "";
            numeroTemporadas = 3;
            entregado = false;
            genero = "";
            creador = "";
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
            numeroTemporadas = 3;
            entregado = false;
            genero = "";
        }

        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.numeroTemporadas = numeroTemporadas;
            this.genero = genero;
            this.creador = creador;
            entregado = false;
        }

        public void Entregar()
        {
            entregado = true;
        }

        public void Devolver()
        {
            entregado = false;
        }

        public bool EstaEntregado()
        {
            return entregado;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Información de la serie:");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Número de Temporadas: {numeroTemporadas}");
            Console.WriteLine($"Entregado: {(entregado ? "Sí" : "No")}");
            Console.WriteLine($"Género: {genero}");
            Console.WriteLine($"Creador: {creador}");
        }
    }

    class Program
    {
        static void Main()
        {
            Serie serie1 = new ();
            Serie serie2 = new ("Breaking Bad", "Vince Gilligan");
            Serie serie3 = new ("Friends", 10, "Comedy", "David Crane & Marta Kauffman");

            Console.WriteLine("Serie 1:");
            serie1.MostrarInformacion();

            Console.WriteLine("\nSerie 2:");
            serie2.MostrarInformacion();

            Console.WriteLine("\nSerie 3:");
            serie3.MostrarInformacion();
        }
    }
}
