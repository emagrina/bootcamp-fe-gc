using ex02.Interface;

namespace ex02.Simple
{
    class Volunteer : IEmployee
    {
        public string Name { get; private set; }

        public Volunteer(string name)
        {
            Name = name;
        }

        public double CalculateSalary()
        {
            return 0;
        }
    }
}

