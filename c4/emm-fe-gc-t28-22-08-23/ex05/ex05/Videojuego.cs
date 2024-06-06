namespace ex05
{
    public class Videojuego : IEntregable
    {
        private string Titulo;
        private int HorasEstimadas;
        private bool Entregado;
        private string Genero;
        private string Compania;

        public Videojuego(string titulo, int horasEstimadas)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
            Entregado = false;
            Genero = "Sin género";
            Compania = "Sin compañía";
        }

        public Videojuego(string titulo, int horasEstimadas, string genero, string compania)
        {
            Titulo = titulo;
            HorasEstimadas = horasEstimadas;
            Entregado = false;
            Genero = genero;
            Compania = compania;
        }

        public int GetHorasEstimadas()
        {
            return HorasEstimadas;
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
            return $"Videojuego: {Titulo}, Horas estimadas: {HorasEstimadas}, Género: {Genero}, Compañía: {Compania}, Entregado: {Entregado}";
        }

        public int CompareTo(object a)
        {
            if (a is Videojuego videojuego)
            {
                return HorasEstimadas.CompareTo(videojuego.HorasEstimadas);
            }
            return 0;
        }
    }
}
