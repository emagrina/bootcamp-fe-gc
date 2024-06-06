namespace ex08
{
    class Program
    {
        static void Main()
        {
            Aula aula = new()
            {
                Identificador = 1,
                MaxEstudiantes = 15,
                MateriaDestinada = Materia.Matematicas,
                Profesor = new Profesor()
            };

            Console.WriteLine("Datos profesor:");
            Console.Write("Nombre: ");
            aula.Profesor.Nombre = Console.ReadLine();

            Console.Write("Edad: ");
            aula.Profesor.Edad = int.Parse(Console.ReadLine());

            Console.Write("Sexo (H/M): ");
            aula.Profesor.Sexo = Enum.Parse<Sexo>(Console.ReadLine());

            Console.Write("Materia (Matematicas/Filosofia/Fisica): ");
            aula.Profesor.MateriaQueDa = Enum.Parse<Materia>(Console.ReadLine());

            aula.Estudiantes = new Estudiante[aula.MaxEstudiantes];

            for (int i = 0; i < aula.MaxEstudiantes; i++)
            {
                Console.WriteLine($"Datos estudiante {i + 1}:");
                Estudiante estudiante = new();
                Console.Write("Nombre: ");
                estudiante.Nombre = Console.ReadLine();

                Console.Write("Edad: ");
                estudiante.Edad = int.Parse(Console.ReadLine());

                Console.Write("Sexo (H/M): ");
                estudiante.Sexo = Enum.Parse<Sexo>(Console.ReadLine());

                Console.Write("Calificacion: ");
                estudiante.CalificacionActual = double.Parse(Console.ReadLine());

                aula.Estudiantes[i] = estudiante;
            }

            if (aula.PuedeDarClase())
            {
                Console.WriteLine($"Cantidad de aprobados: {aula.CantidadAprobados()}");
            }
            else
            {
                Console.WriteLine("No se cumplen los minimos.");
            }
        }
    }
}
