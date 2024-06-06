namespace ex06
{
    class Program
    {
        static void Main()
        {
            Libro libro1 = new();
            libro1.SetISBN("978-0486298238");
            libro1.SetTitulo("Meditaciones");
            libro1.SetAutor("Marco Aurelio");
            libro1.SetNumeroPaginas(256);

            Libro libro2 = new();
            libro2.SetISBN("978-8476004139");
            libro2.SetTitulo("Cartas a Lucilio");
            libro2.SetAutor("Lucio Anneo Séneca");
            libro2.SetNumeroPaginas(352);

            Console.WriteLine(libro1.ToString());
            Console.WriteLine(libro2.ToString());

            Libro libroConMasPaginas = libro1.GetNumeroPaginas() > libro2.GetNumeroPaginas() ? libro1 : libro2;

            Console.WriteLine("El libro con más páginas es: " + libroConMasPaginas.GetTitulo());
        }
    }
}
