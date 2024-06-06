namespace ex03
{
    public class Password
    {
        public const int DEFAULT_LENGTH = 8;
        private const string CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        private int longitud;
        private string contrasena;

        public Password()
        {
            this.longitud = DEFAULT_LENGTH;
            GenerarPassword();
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            GenerarPassword();
        }

        public bool EsFuerte()
        {
            int mayusculas = contrasena.Count(char.IsUpper);
            int minusculas = contrasena.Count(char.IsLower);
            int numeros = contrasena.Count(char.IsDigit);

            return mayusculas > 2 && minusculas > 1 && numeros > 5;
        }

        public void GenerarPassword()
        {
            Random random = new();
            contrasena = new string(Enumerable.Repeat(CHARACTERS, longitud)
                                              .Select(s => s[random.Next(s.Length)])
                                              .ToArray());
        }

        public string GetContrasena()
        {
            return contrasena;
        }

        public int GetLongitud()
        {
            return longitud;
        }

        public void SetLongitud(int longitud)
        {
            this.longitud = longitud;
            GenerarPassword();
        }
    }
}
