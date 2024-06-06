using ex03.Abstract;
using ex03.Interface;
using ex03.Simple;

namespace ex02.Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new();
            List<IPerson> persons = new();

            while (true)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Create Person");
                Console.WriteLine("2. Create Vehicle");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        persons.Add(CreatePerson());
                        break;
                    case 2:
                        vehicles.Add(CreateVehicle(persons));
                        break;
                    case 3:
                        Console.WriteLine("Exit...");
                        return;
                }
            }
        }

        static IPerson CreatePerson()
        {
            Console.Write("Enter person's first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter person's last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter person's birthdate (YYYY-MM-DD): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Is this person a driver or vehicle owner? (D/O): ");
            string personType = Console.ReadLine();

            if (personType.ToUpper() == "D")
            {
                Console.Write("Enter driver's license ID: ");
                string licenseId = Console.ReadLine();

                Console.Write("Enter driver's license type: ");
                string licenseType = Console.ReadLine();

                Console.Write("Enter driver's license expiration date (YYYY-MM-DD): ");
                DateTime expirationDate = DateTime.Parse(Console.ReadLine());

                return new Driver
                {
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate,
                    License = new DriverLicense
                    {
                        ID = licenseId,
                        LicenseType = licenseType,
                        ExpirationDate = expirationDate
                    }
                };
            }
            else if (personType.ToUpper() == "O")
            {
                Console.Write("Does the owner have insurance? (Y/N): ");
                bool hasInsurance = Console.ReadLine().ToUpper() == "Y";

                Console.Write("Does the owner have a garage? (Y/N): ");
                bool hasGarage = Console.ReadLine().ToUpper() == "Y";

                return new VehicleOwner
                {
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate,
                    HasInsurance = hasInsurance,
                    HasGarage = hasGarage
                };
            }
            else
            {
                Console.WriteLine("Invalid.");
                return null;
            }
        }

        static Vehicle CreateVehicle(List<IPerson> persons)
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
                Console.WriteLine("Invalid.");
                return null;
            }

            IPerson owner = ChoosePerson("owner", persons);
            while (true)
            {
                IPerson driver = ChoosePerson("driver", persons);
                if (driver != null)
                {
                    vehicle.AddDriver(driver);
                    Console.Write("Add another driver? (Y/N): ");
                    if (Console.ReadLine().ToUpper() != "Y")
                        break;
                }
                else
                {
                    Console.WriteLine("Invalid.");
                }
            }

            return vehicle;
        }

        static IPerson ChoosePerson(string role, List<IPerson> persons)
        {
            Console.WriteLine($"Choose {role}:");

            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {persons[i].FirstName} {persons[i].LastName}");
            }

            Console.Write("Select a person: ");
            int choice = int.Parse(Console.ReadLine()) - 1;

            if (choice >= 0 && choice < persons.Count)
                return persons[choice];
            else
                return null;
        }
    }
}