using ex01.Interface;

namespace ex01.Simple
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

