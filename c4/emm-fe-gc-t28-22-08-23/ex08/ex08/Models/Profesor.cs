namespace ex08
{
    public enum Materia
    {
        Matematicas,
        Filosofia,
        Fisica
    }

    public class Profesor : Persona
    {
        public Materia MateriaQueDa { get; set; }

        public static bool EstaDisponible()
        {
            Random random = new();
            return random.NextDouble() > 0.2;
        }
    }
}
