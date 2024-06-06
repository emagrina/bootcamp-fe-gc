using System;
using ex02.Abstract;

namespace ex02.Simple
{
    class Car : Vehicle
    {
        public Car(string licensePlate, string brand, string color) : base(licensePlate, brand, color) { }

        public override void AddWheels()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Enter rear wheel {i + 1} brand: ");
                string wheelBrand = Console.ReadLine();

                Console.Write($"Enter rear wheel {i + 1} diameter: ");
                double wheelDiameter = double.Parse(Console.ReadLine());

                AddWheel(wheelBrand, wheelDiameter);
            }

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Enter front wheel {i + 1} brand: ");
                string wheelBrand = Console.ReadLine();

                Console.Write($"Enter front wheel {i + 1} diameter: ");
                double wheelDiameter = double.Parse(Console.ReadLine());

                AddWheel(wheelBrand, wheelDiameter);
            }
        }
    }
}

