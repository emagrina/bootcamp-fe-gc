namespace ex09
{
    public class Cine
    {
        private Pelicula peliculaActual;
        private decimal precioEntrada;
        private Asiento[,] asientos;

        public Cine(Pelicula peliculaActual, decimal precioEntrada, int filas, int columnas)
        {
            this.peliculaActual = peliculaActual;
            this.precioEntrada = precioEntrada;
            asientos = new Asiento[filas, columnas];
            InicializarAsientos();
        }

        private void InicializarAsientos()
        {
            for (int fila = 0; fila < asientos.GetLength(0); fila++)
            {
                for (int columna = 0; columna < asientos.GetLength(1); columna++)
                {
                    asientos[fila, columna] = new Asiento();
                }
            }
        }

        public bool HayAsientosDisponibles()
        {
            foreach (var asiento in asientos)
            {
                if (!asiento.Ocupado)
                {
                    return true;
                }
            }
            return false;
        }

        public bool SentarEspectador(Espectador espectador)
        {
            Random random = new Random();

            if (espectador.Edad >= peliculaActual.EdadMinima && espectador.Dinero >= precioEntrada)
            {
                int fila = random.Next(asientos.GetLength(0));
                int columna = random.Next(asientos.GetLength(1));

                while (asientos[fila, columna].Ocupado)
                {
                    fila = random.Next(asientos.GetLength(0));
                    columna = random.Next(asientos.GetLength(1));
                }

                asientos[fila, columna].Ocupado = true;
                asientos[fila, columna].Espectador = espectador;

                return true;
            }

            return false;
        }

        public void MostrarAsientos()
        {
            Console.WriteLine("Estado de los asientos:");
            for (int fila = asientos.GetLength(0) - 1; fila >= 0; fila--)
            {
                for (int columna = 0; columna < asientos.GetLength(1); columna++)
                {
                    Console.Write(asientos[fila, columna].Ocupado ? "X " : "O ");
                }
                Console.WriteLine();
            }
        }
    }
}
