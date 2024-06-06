using System;
using System.Collections.Generic;
using ex01.Interface;
using ex01.Simple;

namespace PaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> employees = new List<IEmployee>
            {
                new Manager("Mario", 5000),
                new Boss("Marc", 8000),
                new Employee("Ainhoa", 1200),
                new Volunteer("Domingo")
            };

            foreach (IEmployee employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.CalculateSalary():C}");
            }
        }
    }
}
