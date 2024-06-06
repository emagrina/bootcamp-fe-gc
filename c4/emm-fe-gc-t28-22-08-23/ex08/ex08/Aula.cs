namespace ex08
{
    public class Aula
    {
        public int Identificador { get; set; }
        public int MaxEstudiantes { get; set; }
        public Materia MateriaDestinada { get; set; }
        public Profesor? Profesor { get; set; }
        public Estudiante[]? Estudiantes { get; set; }

        public bool PuedeDarClase()
        {
            int estudianteAprobados = 0;
            foreach (Estudiante estudiante in Estudiantes)
            {
                if (estudiante.CalificacionActual >= 5.0)
                {
                    estudianteAprobados++;
                }
            }

            return Profesor.EstaDisponible() &&
                   Profesor.MateriaQueDa == MateriaDestinada &&
                   estudianteAprobados > Estudiantes.Length / 2;
        }

        public int CantidadAprobados()
        {
            int aprobados = 0;
            foreach (Estudiante estudiante in Estudiantes)
            {
                if (estudiante.CalificacionActual >= 5.0)
                {
                    aprobados++;
                }
            }
            return aprobados;
        }
    }
}
