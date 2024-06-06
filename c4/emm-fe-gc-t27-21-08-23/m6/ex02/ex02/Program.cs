using ex02.Abstract;
using ex02.Interface;
using ex02.Simple;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter vehicle type (Car or Bike): ");
            string vehicleType = Console.ReadLine();

            Console.Write("Enter vehicle license plate: ");
            string vehicleLicensePlate = Console.ReadLine();

            Console.Write("Enter vehicle brand: ");
            string vehicleBrand = Console.ReadLine();

            Console.Write("Enter vehicle color: ");
            string vehicleColor = Console.ReadLine();

            Vehicle vehicle;

            if (vehicleType.ToLower() == "car")
            {
                vehicle = new Car(vehicleLicensePlate, vehicleBrand, vehicleColor);
            }
            else if (vehicleType.ToLower() == "bike")
            {
                vehicle = new Bike(vehicleLicensePlate, vehicleBrand, vehicleColor);
            }
            else
            {
                Console.WriteLine("Invalid vehicle type.");
                return;
            }

            vehicle.AddWheels();

            Console.WriteLine($"Vehicle created: {vehicleType} with license plate: {vehicleLicensePlate}, brand: {vehicleBrand}, color: {vehicleColor}");
            Console.WriteLine("Wheels added:");
            foreach (IWheel wheel in vehicle.Wheels)
            {
                Console.WriteLine($"- Brand: {wheel.Brand}, Diameter: {wheel.Diameter}");
            }
        }
    }
}
