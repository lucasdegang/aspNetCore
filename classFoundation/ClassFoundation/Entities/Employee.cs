using System.Globalization;

namespace ClassFoundation.Entities
{
    public class Employee
    {
        // constructor - sobrecarga/ overload
        public Employee() { }

        public Employee(string name, double salary, double tax)
        {
            Name = name;
            Salary = salary;
            Tax = tax;
        }

        public double SalaryTax()
        {
            return Salary - Tax;
        }

        public void SalaryPercentageGain(double percent)
        {
            Salary = Salary + (Salary * percent / 100);
        }

        // convert the object <Employee> in string
        public override string ToString()
        {
            return $"Employee name {Name} salary with taxes discounted {SalaryTax().ToString("F2", CultureInfo.CurrentCulture)}";
        }

        // attributes
        public string Name;
        public double Salary, Tax;
    }
}
