
namespace ex07
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());

            Raices ecuacion = new(a, b, c);

            Console.WriteLine("Resultado:");
            ecuacion.Calcular();
        }
    }
}
