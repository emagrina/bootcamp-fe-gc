using System;
namespace ex01.Simple
{
    class Bike : Vehicle
    {
        public Bike(string licensePlate, string brand, string color) : base(licensePlate, brand, color) { }

        public override void AddWheels()
        {
            Console.WriteLine("Adding rear wheel for the bike...");
            Console.Write("Enter rear wheel brand: ");
            string wheelBrand = Console.ReadLine();

            Console.Write("Enter rear wheel diameter: ");
            double wheelDiameter = double.Parse(Console.ReadLine());

            AddWheel(wheelBrand, wheelDiameter);

            Console.WriteLine("Adding front wheel for the bike...");
            Console.Write("Enter front wheel brand: ");
            wheelBrand = Console.ReadLine();

            Console.Write("Enter front wheel diameter: ");
            wheelDiameter = double.Parse(Console.ReadLine());

            AddWheel(wheelBrand, wheelDiameter);
        }
    }
}

