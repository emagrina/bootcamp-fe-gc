using ex01.Interface;

namespace ex01.Simple
{
    class Manager : IEmployee
    {
        public string Name { get; private set; }
        private double BaseSalary;

        public Manager(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public double CalculateSalary()
        {
            return BaseSalary * 1.1;
        }
    }

}

