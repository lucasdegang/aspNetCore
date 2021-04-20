using ClassFoundation.Processing;
using System;

namespace ClassFoundation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SystemMessage("Lucas"));

            ProductProcessing productP = new ProductProcessing();
            productP.Processing();
            
            EmployeeProcessing employeeP = new EmployeeProcessing();
            employeeP.Processing(); 
        }
        
        static string SystemMessage(string user)
        {
            return $"Welcome {user}";
        }
    }
}
