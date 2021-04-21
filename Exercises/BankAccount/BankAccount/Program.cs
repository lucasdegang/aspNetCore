using BankAccount.Entities;
using System;
using System.Globalization;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Management Account // Bank Universal");

            Console.WriteLine();
            Console.Write("Id Account: ");
            int idAccount = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("User name: ");
            string userName = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Initial Deposit [ 1 - yes ] [ 2 - no ]  ?: ");
            int initDeposit = int.Parse(Console.ReadLine());

            double value = 0;

            if (initDeposit == 1)
            {
                Console.WriteLine();
                Console.Write("Deposit Initial Value: ");
                value = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
            }

            Account account = new Account(idAccount, userName, value);

            Console.WriteLine();
            Console.Write("Account info: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Deposit Value: ");
            value = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
            account.AddMoney(value);

            Console.WriteLine();
            Console.Write("Account info: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Draw Money: ");
            value = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
            account.TakeMoney(value);

            Console.WriteLine();
            Console.Write("Account info: ");
            Console.WriteLine(account);
        }
    }
}
