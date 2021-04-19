using ClassFoundation.Entities;
using System;
using System.Globalization;

namespace ClassFoundation.Processing
{
    public class EmployeeProcessing
    {
        public void Processing()
        {
            // class instance
            Employee e;

            Console.WriteLine("### Employee Costs");
            
            Console.WriteLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            Console.WriteLine();
            Console.Write("Tax: ");
            double tax = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            Console.WriteLine();
            Console.Write("Salary bonus in %: ");
            var bonusPercent = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            e = new Employee(name, salary, tax);

            e.SalaryPercentageGain(bonusPercent);

            Console.WriteLine();
            Console.WriteLine(e);
        }
    }
}
