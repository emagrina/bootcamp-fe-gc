namespace ex06
{
    public class Libro
    {
        private string? ISBN;
        private string? Titulo;
        private string? Autor;
        private int NumeroPaginas;

        public string GetISBN()
        {
            return ISBN;
        }

        public void SetISBN(string isbn)
        {
            ISBN = isbn;
        }

        public string GetTitulo()
        {
            return Titulo;
        }

        public void SetTitulo(string titulo)
        {
            Titulo = titulo;
        }

        public string GetAutor()
        {
            return Autor;
        }

        public void SetAutor(string autor)
        {
            Autor = autor;
        }

        public int GetNumeroPaginas()
        {
            return NumeroPaginas;
        }

        public void SetNumeroPaginas(int numeroPaginas)
        {
            NumeroPaginas = numeroPaginas;
        }

        public override string ToString()
        {
            return $"El libro {Titulo} con ISBN {ISBN} creado por {Autor} tiene {NumeroPaginas} páginas.";
        }
    }
}
