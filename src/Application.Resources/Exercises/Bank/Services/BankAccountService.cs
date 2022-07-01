using Application.Commands.Exercises.Bank.Interfaces;
using Application.Commands.Exercises.Bank.Models;

namespace Application.Commands.Exercises.Bank.Services
{
    public class BankAccountService : IBankAccountService
    {
        // here usually comes IRepository dependency injection
        // but in this exercise it wont necessary, all data will be in memory
        // and some of parameters must be given to application works successfully 

        private BankOperationsService _bankOperationsService;

        public BankAccountService(BankOperationsService bankOperationsService)
        {
            _bankOperationsService = bankOperationsService;
        }

        public async Task<string> Compensation(int id, double balance, double value)
        {
            var result = await _bankOperationsService.Compensation(id, balance, value);
            return result.ToString();
        }

        public async Task<string> CreateAccount(int id, string name, string passPort, string nationality, Address address, double balance, string currency)
        {
            BankAccount.AccountValidator(id, name, passPort, nationality, address, balance, currency);

            BankAccount account = new BankAccount(id, name, passPort, nationality, address, balance, currency);

            // using repository here is the point where must save in DB
            
            var result = Task.Run(() => account.ToString());
            result.Wait();

            return await result;
        }

        public async Task<string> Deposit(int id, double balance, double value)
        {
            var result = await _bankOperationsService.Deposit(id, balance, value);
            return result.ToString();
        }

        public async Task<string> GetBalance(int id, double balance)
        {
            // using repository here is used id to search the balance by id. 
            var result = Task.Run(() => balance.ToString());
            result.Wait();

            return await result;
        }
    }
}
