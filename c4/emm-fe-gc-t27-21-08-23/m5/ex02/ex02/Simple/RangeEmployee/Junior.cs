namespace ex02.Simple.RangeEmployee
{
    class Junior : Employee
    {
        public Junior(string name, double baseSalary) : base(name, baseSalary)
        {
            if (baseSalary < 900 || baseSalary >= 1600)
            {
                throw new ArgumentOutOfRangeException("Junior salary should be between 900 and 1600.");
            }
        }

        public override double CalculateSalary()
        {
            return BaseSalary * 0.85;
        }
    }
}

