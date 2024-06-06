using System;

namespace ex08
{
    class Password
    {
        private readonly int longitud;
        private readonly string contrasena;

        public Password()
        {
            longitud = 8;
            contrasena = GenerarContrasena(longitud);
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            contrasena = GenerarContrasena(longitud);
        }

        private string GenerarContrasena(int longitud)
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();
            char[] contrasenaArray = new char[longitud];

            for (int i = 0; i < longitud; i++)
            {
                contrasenaArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new string(contrasenaArray);
        }

        public void MostrarContrasena()
        {
            Console.WriteLine($"Contrasena generada: {contrasena}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Password contrasenaDefecto = new();
            Password contrasenaPersonalizada = new(12);

            Console.WriteLine("Contraseña por defecto:");
            contrasenaDefecto.MostrarContrasena();

            Console.WriteLine("\nContraseña personalizada:");
            contrasenaPersonalizada.MostrarContrasena();
        }
    }
}
