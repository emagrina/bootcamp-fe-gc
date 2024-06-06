using ex01.Interface;

namespace ex01.Simple
{
    class Boss : IEmployee
    {
        public string Name { get; private set; }
        private double BaseSalary;

        public Boss(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public double CalculateSalary()
        {
            return BaseSalary * 1.5;
        }
    }

}

