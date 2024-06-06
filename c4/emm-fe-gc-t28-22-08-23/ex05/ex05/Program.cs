namespace ex05
{
    class Program
    {
        static void Main()
        {
            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];

            series[0] = new Serie("Narcos", "Pablo");
            series[1] = new Serie("LQSA", 8, "Accion", "Jesus");
            series[2] = new Serie("Breaking Bad", 5, "Aventura", "Walter");
            series[3] = new Serie("Walking dead", 3, "Acción", "Sam");
            series[4] = new Serie("La casa de papel", "Berlin");

            videojuegos[0] = new Videojuego("Pokemon", 50);
            videojuegos[1] = new Videojuego("Age of titans", 20, "Estrategia", "Sony");
            videojuegos[2] = new Videojuego("Fifa", 8, "Deportes", "EA");
            videojuegos[3] = new Videojuego("WoW D", 300, "RPG", "Wizard");
            videojuegos[4] = new Videojuego("Valorant E", 2, "Shooter", "Shooter");

            series[1].Entregar();
            series[3].Entregar();
            videojuegos[0].Entregar();
            videojuegos[3].Entregar();

            int seriesEntregadas = ContarEntregados(series);
            int videojuegosEntregados = ContarEntregados(videojuegos);

            Console.WriteLine($"Cantidad de series entregadas: {seriesEntregadas}");
            Console.WriteLine($"Cantidad de videojuegos entregados: {videojuegosEntregados}");

            Serie serieConMasTemporadas = ObtenerMaximo(series);
            Videojuego videojuegoConMasHoras = ObtenerMaximo(videojuegos);

            Console.WriteLine("Serie con más temporadas:");
            Console.WriteLine(serieConMasTemporadas);

            Console.WriteLine("Videojuego con más horas:");
            Console.WriteLine(videojuegoConMasHoras);
        }

        static int ContarEntregados(IEntregable[] entregables)
        {
            int count = 0;
            foreach (IEntregable entregable in entregables)
            {
                if (entregable.IsEntregado())
                {
                    count++;
                }
            }
            return count;
        }

        static T ObtenerMaximo<T>(T[] array) where T : IEntregable
        {
            T maximo = array[0];
            foreach (T item in array)
            {
                if (item is Serie serie && maximo is Serie maxSerie)
                {
                    if (serie.GetNumeroTemporadas() > maxSerie.GetNumeroTemporadas())
                    {
                        maximo = item;
                    }
                }
                else if (item is Videojuego videojuego && maximo is Videojuego maxVideojuego)
                {
                    if (videojuego.GetHorasEstimadas() > maxVideojuego.GetHorasEstimadas())
                    {
                        maximo = item;
                    }
                }
            }
            return maximo;
        }
    }
}
