namespace ex05
{
    public class Serie : IEntregable
    {
        private readonly string Titulo;
        private readonly int NumeroTemporadas;
        private bool Entregado;
        private readonly string Genero;
        private readonly string Creador;

        public Serie(string titulo, string creador)
        {
            Titulo = titulo;
            NumeroTemporadas = 3;
            Entregado = false;
            Genero = "Sin género";
            Creador = creador;
        }

        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
        {
            Titulo = titulo;
            NumeroTemporadas = numeroTemporadas;
            Entregado = false;
            Genero = genero;
            Creador = creador;
        }

        public int GetNumeroTemporadas()
        {
            return NumeroTemporadas;
        }

        public void Entregar()
        {
            Entregado = true;
        }

        public void Devolver()
        {
            Entregado = false;
        }

        public bool IsEntregado()
        {
            return Entregado;
        }

        public override string ToString()
        {
            return $"Serie: {Titulo}, Temporadas: {NumeroTemporadas}, Género: {Genero}, Creador: {Creador}, Entregado: {Entregado}";
        }

        public int CompareTo(object a)
        {
            if (a is Serie serie)
            {
                return NumeroTemporadas.CompareTo(serie.NumeroTemporadas);
            }
            return 0;
        }
    }
}
