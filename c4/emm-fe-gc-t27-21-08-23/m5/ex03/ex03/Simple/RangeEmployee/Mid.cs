namespace ex03.Simple.RangeEmployee
{
    class Mid : Employee
    {
        public Mid(string name, double baseSalary) : base(name, baseSalary, 0.15) { }

        public override void EmitBonus()
        {
            Console.WriteLine($"Mid: {Name}, bonus of {CalculateNetAnnual() * 0.1:C}.");
        }
    }
}

