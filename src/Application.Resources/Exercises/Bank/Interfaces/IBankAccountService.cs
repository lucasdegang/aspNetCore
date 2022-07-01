using Application.Commands.Exercises.Bank.Models;

namespace Application.Commands.Exercises.Bank.Interfaces
{
    public interface IBankAccountService
    {
        Task<string> CreateAccount(int id, string name, string passPort, string nationality, Address address, double balance, string currency);
        Task<string> GetBalance(int id, double balance);
        Task<string> Deposit(int id, double balance, double value);
        Task<string> Compensation(int id, double balance, double value);
    }
}
