namespace Application.Commands.Exercises.Bank.Interfaces
{
    public interface IBankOperationsService
    {
        Task<double> Compensation(int id, double balance, double value);
        Task<double> Deposit(int id, double balance, double value);
    }
}
