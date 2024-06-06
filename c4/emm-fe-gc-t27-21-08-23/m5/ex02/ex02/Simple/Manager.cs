namespace ex02.Simple
{
    class Manager : Employee
    {
        public Manager(string name, double baseSalary) : base(name, baseSalary)
        {
            if (baseSalary < 3000 || baseSalary >= 5000)
            {
                throw new ArgumentOutOfRangeException("Manager salary should be between 3000 and 5000.");
            }
        }

        public override double CalculateSalary()
        {
            return BaseSalary * 1.1;
        }
    }
}

