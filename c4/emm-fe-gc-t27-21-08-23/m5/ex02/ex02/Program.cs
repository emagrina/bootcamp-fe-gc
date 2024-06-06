using ex02.Interface;
using ex02.Simple;
using ex02.Simple.RangeEmployee;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            // We will indicate that our default currency is €
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-ES");

            List<IEmployee> employees = new()
            {
                new Manager("Mercedes", 4000),
                new Boss("Adrian", 9000),
                new Junior("María", 1200),
                new Mid("Gabriel", 2000),
                new Senior("Carolina", 3200),
                new Volunteer("Elena")
            };

            foreach (IEmployee emp in employees)
            {
                Console.WriteLine($"Employee: {emp.Name}, Salary: {emp.CalculateSalary():C}");
            }
        }
    }
}
