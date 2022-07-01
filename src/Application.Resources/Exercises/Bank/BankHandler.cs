using Application.Commands.Exercises.Bank.Models;
using Application.Commands.Exercises.Bank.Services;

namespace Application.Commands.Exercises.Bank
{
    public class BankHandler
    {
        private BankAccountService _bankAccountService;

        public BankHandler(BankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        public async Task<string> BankOptionsService(int option)
        {
            // this is like a mock as it wont go to live env, wont have a problems.

            Address address = new Address
            {
                City = "Sao Paulo",
                Complement = "Office A",
                Country = "Brazil",
                Number = 1,
                State = "Sao Paulo",
                Street = "Avenida Paulista"
            };

            BankAccount account = new BankAccount(1, "System", "ABC123456", "Brazilian", address, 500.00, "$");

            if (option.Equals(null))
            {
                throw new ArgumentNullException("Exercise>Bank>BankHandler>BankOptionsService with option=[null]");
            } 

            switch (option)
            {
                // account.Id, account.Name, account.PassPort,
                //      account.Nationality, account.Address, account.Balance, account.Currency
                // to this implementation stay ok, the data account must be taken on DB by repository

                case 1:
                    var compensation = await _bankAccountService.Compensation(account.Id, account.Balance, 250.00);
                    return compensation.ToString();

                case 2:
                    var createAccount = await _bankAccountService.CreateAccount(account.Id, account.Name, account.PassPort,
                        account.Nationality, account.Address, account.Balance, account.Currency);
                    return createAccount.ToString();

                case 3:
                    var deposit = await _bankAccountService.Deposit(account.Id, account.Balance, 368.50);
                    return deposit.ToString();

                case 4:
                    var balance = await _bankAccountService.GetBalance(account.Id, account.Balance);
                    return balance.ToString();

                default:
                    throw new Exception("Exercise>Bank>BankHandler>BankOptionsService Invalid option value");
            }
        }
    }
}
