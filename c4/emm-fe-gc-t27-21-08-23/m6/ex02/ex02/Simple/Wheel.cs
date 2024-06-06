using ex02.Interface;

namespace ex02.Simple
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

