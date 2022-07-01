using Application.Commands.Exercises.Bank.Interfaces;

namespace Application.Commands.Exercises.Bank.Services
{
    public abstract class BankOperationsService : IBankOperationsService
    {
        public async Task<double> Compensation(int id, double balance, double value)
        {
            OperationExceptionMessage("Compensation", id, value);

            var result = Task.Run(() => (balance - value));
            result.Wait();

            return await result;
        }

        public async Task<double> Deposit(int id, double balance, double value)
        {
            OperationExceptionMessage("Deposit", id, value);

            var result = Task.Run(() => (balance + value));
            result.Wait();

            return await result;
        }

        public static void OperationExceptionMessage(string method, int id, double value)
        {
            if (id.Equals(null) || value.Equals(null))
            {
                throw new Exception($"Exercise>Bank>BankOperationsService>{method} parameter(s) value(s)");
            }
        }
    }
}
