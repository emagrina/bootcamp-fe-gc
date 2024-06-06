using System;
using ex03.Interface;

namespace ex03.Simple
{
    class Volunteer : IEmployee
    {
        public string Name { get; private set; }
        private readonly bool GovernmentAid;

        public Volunteer(string name, bool governmentAid)
        {
            Name = name;
            GovernmentAid = governmentAid;
        }

        public double CalculateGrossMonthly()
        {
            return GovernmentAid ? 300 : 0;
        }

        public double CalculateNetMonthly()
        {
            return CalculateGrossMonthly();
        }

        public double CalculateGrossAnnual()
        {
            return CalculateGrossMonthly() * 12;
        }

        public double CalculateNetAnnual()
        {
            return CalculateGrossAnnual();
        }

        public void EmitBonus()
        {
            Console.WriteLine($"Volunteer {Name} is not bonus.");
        }
    }
}

