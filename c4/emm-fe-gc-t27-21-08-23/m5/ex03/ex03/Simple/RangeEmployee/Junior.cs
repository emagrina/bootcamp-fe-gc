using System;
namespace ex03.Simple.RangeEmployee
{
    class Junior : Employee
    {
        public Junior(string name, double baseSalary) : base(name, baseSalary, 0.02) { }

        public override void EmitBonus()
        {
            Console.WriteLine($"Junior: {Name}, bonus of {CalculateNetAnnual() * 0.1:C}.");
        }
    }
}

