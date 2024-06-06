using System;
using ex02.Interface;

namespace ex02.Simple
{
    class Employee : IEmployee
    {
        public string Name { get; private set; }
        protected double BaseSalary;

        public Employee(string name, double baseSalary)
        {
            Name = name;
            if (baseSalary < 0)
            {
                throw new ArgumentOutOfRangeException("Base salary cannot be negative.");
            }
            BaseSalary = baseSalary;
        }

        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }
    }
}

