namespace ex02
{
    class Persona
    {
        public const char SEXO_POR_DEFECTO = 'H';
        public const int IMC_DEBAJO_PESO_IDEAL = -1;
        public const int IMC_PESO_IDEAL = 0;
        public const int IMC_SOBREPESO = 1;

        private string nombre;
        private int edad;
        private char sexo;
        private double peso;
        private double altura;
        private string dni;

        public Persona()
        {
            this.nombre = "";
            this.edad = 0;
            this.sexo = SEXO_POR_DEFECTO;
            this.peso = 0;
            this.altura = 0;
            this.dni = GenerarDNI();
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = ComprobarSexo(sexo);
            this.peso = 0;
            this.altura = 0;
            this.dni = GenerarDNI();
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = ComprobarSexo(sexo);
            this.peso = peso;
            this.altura = altura;
            this.dni = GenerarDNI();
        }

        private static char ComprobarSexo(char sexo)
        {
            return (sexo == 'H' || sexo == 'M') ? sexo : SEXO_POR_DEFECTO;
        }

        public int CalcularIMC()
        {
            double imc = peso / (altura * altura);

            if (imc < 20)
            {
                return IMC_DEBAJO_PESO_IDEAL;
            }
            else if (imc >= 20 && imc <= 25)
            {
                return IMC_PESO_IDEAL;
            }
            else
            {
                return IMC_SOBREPESO;
            }
        }

        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }

        private static string GenerarDNI()
        {
            Random random = new();
            int dniNumero = random.Next(10000000, 99999999);
            int resto = dniNumero % 23;
            char[] letraDNI = "TRWAGMYFPDXBNJZSQVHLCKE".ToCharArray();
            return dniNumero.ToString() + letraDNI[resto];
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Edad: {edad}, DNI: {dni}, Sexo: {sexo}, Peso: {peso}, Altura: {altura}";
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void SetSexo(char sexo)
        {
            this.sexo = ComprobarSexo(sexo);
        }

        public void SetPeso(double peso)
        {
            this.peso = peso;
        }

        public void SetAltura(double altura)
        {
            this.altura = altura;
        }
    }
}
