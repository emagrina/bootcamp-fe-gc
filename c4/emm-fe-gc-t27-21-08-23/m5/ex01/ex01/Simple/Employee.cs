using ex01.Interface;

namespace ex01.Simple
{
    class Employee : IEmployee
    {
        public string Name { get; private set; }
        private double BaseSalary;

        public Employee(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public double CalculateSalary()
        {
            return BaseSalary * 0.85;
        }
    }
}

