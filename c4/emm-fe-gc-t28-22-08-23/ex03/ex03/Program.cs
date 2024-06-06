namespace ex03
{
    class Program
    {
        static void Main()
        {
            Console.Write("Cantidad de contraseñas: ");
            int cantidadContrasenas = int.Parse(Console.ReadLine());

            Password[] contrasenas = new Password[cantidadContrasenas];
            bool[] contrasenasFuertes = new bool[cantidadContrasenas];

            Console.Write("Longitud de las contraseñas: ");
            string inputLongitud = Console.ReadLine();
            int longitudContrasena = string.IsNullOrEmpty(inputLongitud) ? Password.DEFAULT_LENGTH : int.Parse(inputLongitud);

            for (int i = 0; i < cantidadContrasenas; i++)
            {
                contrasenas[i] = new Password(longitudContrasena);
                contrasenasFuertes[i] = contrasenas[i].EsFuerte();
            }

            Console.WriteLine("\nContraseñas:\n");

            for (int i = 0; i < cantidadContrasenas; i++)
            {
                Console.WriteLine($"Contraseña {i + 1}: {contrasenas[i].GetContrasena()}, Fuerte: {contrasenasFuertes[i]}");
            }
        }
    }
}
