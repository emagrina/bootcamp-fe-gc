namespace ex02.Simple.RangeEmployee
{
    class Senior : Employee
    {
        public Senior(string name, double baseSalary) : base(name, baseSalary)
        {
            if (baseSalary < 2700 || baseSalary >= 4000)
            {
                throw new ArgumentOutOfRangeException("Senior salary should be between 2700 and 4000.");
            }
        }

        public override double CalculateSalary()
        {
            return BaseSalary * 0.95;
        }
    }
}

