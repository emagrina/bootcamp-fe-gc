using System;
using System.Collections.Generic;
using ex03.Interface;
using ex03.Simple;
using ex03.Simple.RangeEmployee;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-ES");

            List<IEmployee> employees = new()
            {
                new Manager("Antonia", 4000),
                new Boss("Rosa", 9000),
                new Junior("Emilio", 1200),
                new Mid("Vicente", 2000),
                new Senior("Hector", 3200),
                new Volunteer("Charlie", true),
                new Volunteer("Ana Isabel", false)
            };

            foreach (IEmployee emp in employees)
            {
                Console.WriteLine($"Employee: {emp.Name}");
                Console.WriteLine($"Gross Monthly: {emp.CalculateGrossMonthly():C}");
                Console.WriteLine($"Net Monthly: {emp.CalculateNetMonthly():C}");
                Console.WriteLine($"Gross Annual: {emp.CalculateGrossAnnual():C}");
                Console.WriteLine($"Net Annual: {emp.CalculateNetAnnual():C}");
                emp.EmitBonus();
                Console.WriteLine();
            }
        }
    }
}
