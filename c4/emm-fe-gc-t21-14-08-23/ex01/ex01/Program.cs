using System;
namespace ex01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular el area:");
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Cuadrado");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateCircleArea();
                    break;
                case 2:
                    CalculateTriangleArea();
                    break;
                case 3:
                    CalculateSquareArea();
                    break;
            }

            Console.ReadLine();
        }

        static void CalculateCircleArea()
        {
            Console.Write("Introcude el radio: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area circulo: {area}");
        }

        static void CalculateTriangleArea()
        {
            Console.Write("Introcude la base: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introcude la altura: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = (baseLength * height) / 2;
            Console.WriteLine($"Area triangulo: {area}");
        }

        static void CalculateSquareArea()
        {
            Console.Write("Introcude el lado: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            double area = Math.Pow(sideLength, 2);
            Console.WriteLine($"Area cuadrado: {area}");
        }

    }
}

