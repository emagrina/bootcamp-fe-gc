namespace ex03.Simple.RangeEmployee
{
    class Senior : Employee
    {
        public Senior(string name, double baseSalary) : base(name, baseSalary, 0.24) { }

        public override void EmitBonus()
        {
            Console.WriteLine($"Senior: {Name}, bonus of {CalculateNetAnnual() * 0.1:C}.");
        }
    }
}

