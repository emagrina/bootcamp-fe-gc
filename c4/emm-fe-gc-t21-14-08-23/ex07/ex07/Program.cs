using System;

namespace ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor en EUR: ");
            double euros = Convert.ToDouble(Console.ReadLine());

            Console.Write("A que moneda conversar (GBP, USD o JPY): ");
            string targetCurrency = Console.ReadLine();

            ConvertCurrency(euros, targetCurrency);

            Console.ReadLine();
        }

        static void ConvertCurrency(double euros, string targetCurrency)
        {
            double exchangeRate = 0;

            switch (targetCurrency.ToUpper())
            {
                case "GBP":
                    exchangeRate = 0.86;
                    break;
                case "USD":
                    exchangeRate = 1.28611;
                    break;
                case "JPY":
                    exchangeRate = 129.852;
                    break;
                default:
                    Console.WriteLine("Moneda no valida.");
                    return;
            }

            double convertedAmount = euros * exchangeRate;
            Console.WriteLine($"{euros} EUR = {convertedAmount} {targetCurrency}");
        }
    }
}
