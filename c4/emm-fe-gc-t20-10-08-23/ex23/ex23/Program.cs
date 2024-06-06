namespace CalculadoraInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer valor:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese el signo aritmetico (+, -, *, /, ^, %):");
            char signo = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result = 0;

            switch (signo)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = (double)num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("DivideByZero");
                        return;
                    }
                    break;
                case '^':
                    result = Math.Pow(num1, num2);
                    break;
                case '%':
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Signo aritmetico no valido.");
                    return;
            }

            Console.WriteLine($"El resultado es: {result}");
        }
    }
}