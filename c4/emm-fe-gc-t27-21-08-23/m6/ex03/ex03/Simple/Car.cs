using ex03.Abstract;

namespace ex03.Simple
{
    class Car : Vehicle
    {
        public Car(string licensePlate, string brand, string color) : base(licensePlate, brand, color) { }

        public override void AddWheels()
        {
            Console.Write("Enter wheel brand: ");
            string wheelBrand = Console.ReadLine();

            Console.Write("Enter wheel diameter: ");
            double wheelDiameter = double.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                AddWheel(wheelBrand, wheelDiameter);
            }
        }
    }
}

