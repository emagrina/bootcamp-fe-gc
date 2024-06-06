using ex03.Interface;

namespace ex03.Simple
{
    class Wheel : IWheel
    {
        public string Brand { get; set; }
        public double Diameter { get; set; }

        public Wheel(string brand, double diameter)
        {
            Brand = brand;
            Diameter = diameter;
        }
    }
}

