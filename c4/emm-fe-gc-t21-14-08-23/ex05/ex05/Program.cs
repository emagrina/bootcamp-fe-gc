
namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un valor decimal: ");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());

            string binaryNumber = ConvertToBinary(decimalNumber);
            
            Console.WriteLine($"{decimalNumber} = {binaryNumber}");

            Console.ReadLine();
        }

        static string ConvertToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
            {
                return "0";
            }

            string binary = "";

            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder + binary;
                decimalNumber /= 2;
            }

            return binary;
        }
    }
}
