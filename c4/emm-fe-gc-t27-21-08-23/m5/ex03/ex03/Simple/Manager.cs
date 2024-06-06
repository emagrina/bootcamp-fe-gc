using System;
namespace ex03.Simple
{
    class Manager : Employee
    {
        public Manager(string name, double baseSalary) : base(name, baseSalary, 0.26) { }

        public override void EmitBonus()
        {
            Console.WriteLine($"Manager {Name}, bonus of {CalculateNetAnnual() * 0.1:C}.");
        }
    }
}

