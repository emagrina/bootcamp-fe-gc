namespace ex08
{
    public enum Sexo
    {
        H, M
    }

    public class Persona
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public Sexo Sexo { get; set; }
    }
}
