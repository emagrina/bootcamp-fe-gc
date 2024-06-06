using System;
using ex03.Abstract;

namespace ex03.Simple
{
    class Bike : Vehicle
    {
        public Bike(string licensePlate, string brand, string color) : base(licensePlate, brand, color) { }

        public override void AddWheels()
        {
            Console.Write("Enter rear wheel brand: ");
            string wheelBrand = Console.ReadLine();

            Console.Write("Enter rear wheel diameter: ");
            double wheelDiameter = double.Parse(Console.ReadLine());

            AddWheel(wheelBrand, wheelDiameter);

            Console.Write("Enter front wheel brand: ");
            wheelBrand = Console.ReadLine();

            Console.Write("Enter front wheel diameter: ");
            wheelDiameter = double.Parse(Console.ReadLine());

            AddWheel(wheelBrand, wheelDiameter);
        }
    }
}