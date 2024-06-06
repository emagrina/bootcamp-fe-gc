namespace ex02.Simple.RangeEmployee
{
    class Mid : Employee
    {
        public Mid(string name, double baseSalary) : base(name, baseSalary)
        {
            if (baseSalary < 1800 || baseSalary >= 2500)
            {
                throw new ArgumentOutOfRangeException("Mid salary should be between 1800 and 2500.");
            }
        }

        public override double CalculateSalary()
        {
            return BaseSalary * 0.9;
        }
    }
}

