namespace ex03.Simple
{
    class Boss : Employee
    {
        public Boss(string name, double baseSalary) : base(name, baseSalary, 0.32) { }

        public override void EmitBonus()
        {
            Console.WriteLine($"Boss {Name}, Bonus of {CalculateNetAnnual() * 0.1:C}.");
        }
    }
}

