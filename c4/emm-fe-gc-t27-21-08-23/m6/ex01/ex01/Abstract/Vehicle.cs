using ex01.Interfaces;

namespace ex01.Simple
{
    abstract class Vehicle
    {
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public List<IWheel> Wheels { get; set; }

        public Vehicle(string licensePlate, string brand, string color)
        {
            if (!IsValidLicensePlate(licensePlate))
            {
                throw new ArgumentException("Invalid license plate format.");
            }

            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            Wheels = new List<IWheel>();
        }

        public void AddWheel(string brand, double diameter)
        {
            if (diameter < 0.4 || diameter > 4)
            {
                throw new ArgumentException("Invalid wheel diameter. Must be between 0.4 and 4.");
            }

            if (Wheels.Count < 4)
            {
                Wheels.Add(new Wheel(brand, diameter));
                Console.WriteLine("Wheel added.");
            }
            else
            {
                Console.WriteLine("Cannot add more than 4 wheels.");
            }
        }

        private static bool IsValidLicensePlate(string licensePlate)
        {
            if (licensePlate.Length >= 6 && licensePlate.Length <= 7)
            {
                bool hasNumbers = false;
                bool hasLetters = false;

                foreach (char c in licensePlate)
                {
                    if (char.IsDigit(c))
                    {
                        hasNumbers = true;
                    }
                    else if (char.IsLetter(c))
                    {
                        hasLetters = true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return hasNumbers && hasLetters;
            }

            return false;
        }

        public abstract void AddWheels();
    }
}

