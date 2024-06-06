namespace ex08
{
    public class Estudiante : Persona
    {
        public double CalificacionActual { get; set; }

        public static bool HaceNovillos()
        {
            Random random = new();
            return random.NextDouble() < 0.5;
        }
    }
}
