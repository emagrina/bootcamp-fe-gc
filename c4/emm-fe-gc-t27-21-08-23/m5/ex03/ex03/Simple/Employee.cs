using ex03.Interface;

namespace ex03.Simple
{
    class Employee : IEmployee
    {
        public string Name { get; private set; }
        protected double BaseSalary;
        protected double IRPFTaxRate;

        public Employee(string name, double baseSalary, double irpfTaxRate)
        {
            Name = name;
            if (baseSalary < 0)
            {
                throw new ArgumentOutOfRangeException("Base salary cannot be negative.");
            }
            BaseSalary = baseSalary;
            IRPFTaxRate = irpfTaxRate;
        }

        public virtual double CalculateGrossMonthly()
        {
            return BaseSalary;
        }

        public virtual double CalculateNetMonthly()
        {
            return CalculateGrossMonthly() * (1 - IRPFTaxRate);
        }

        public virtual double CalculateGrossAnnual()
        {
            return CalculateGrossMonthly() * 12;
        }

        public virtual double CalculateNetAnnual()
        {
            return CalculateNetMonthly() * 12;
        }

        public virtual void EmitBonus()
        {
            // No action for base employee class
        }
    }

}