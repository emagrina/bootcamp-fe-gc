namespace ex22
{
    class ex22
    {
        static void Main(string[] args)
        {
            const string PASSWORD = "Qwerty123";
            int intentosRestantes = 3;

            for (int intento = 1; intento <= 3; intento++)
            {
                Console.WriteLine("Introduce la contraseña:");
                string passwdIngresada = Console.ReadLine();

                if (passwdIngresada == PASSWORD)
                {
                    Console.WriteLine("¡Enhorabuena!");
                    break;
                }
                else
                {
                    intentosRestantes--;
                    Console.WriteLine($"Contrasena incorrecta. Te quedan {intentosRestantes} intentos.");
                }
            }

            if(intentosRestantes == 0)
            {
                Console.WriteLine("*Bloqueado*");
            }
        }
    }
}