using ex01.Clases;

namespace ex01
{
    class Program
    {
        static void Main()
        {
            Cuenta cuenta1 = new("Mercedes Muñoz");
            Console.WriteLine(cuenta1);

            Cuenta cuenta2 = new("Enrique Ortiz", 1000);
            Console.WriteLine(cuenta2);

            cuenta1.Ingresar(700);
            cuenta2.Retirar(500);

            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);
        }
    }
}

