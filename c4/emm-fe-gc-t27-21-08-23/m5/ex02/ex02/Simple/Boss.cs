namespace ex02.Simple
{
    class Boss : Employee
    {
        public Boss(string name, double baseSalary) : base(name, baseSalary)
        {
            if (baseSalary <= 8000)
            {
                throw new ArgumentOutOfRangeException("Boss salary should be more than 8000.");
            }
        }

        public override double CalculateSalary()
        {
            return BaseSalary;
        }
    }
}

