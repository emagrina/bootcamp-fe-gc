namespace ex01.Simple
{
    class Car : Vehicle
    {
        public Car(string licensePlate, string brand, string color) : base(licensePlate, brand, color) { }

        public override void AddWheels()
        {
            Console.WriteLine("Adding rear wheels for the car...");
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Enter rear wheel {i + 1} brand: ");
                string wheelBrand = Console.ReadLine();

                Console.Write($"Enter rear wheel {i + 1} diameter: ");
                double wheelDiameter = double.Parse(Console.ReadLine());

                AddWheel(wheelBrand, wheelDiameter);
            }

            Console.WriteLine("Adding front wheels for the car...");
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

