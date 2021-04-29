using System.Globalization;

namespace BankAccount.Entities
{
    public class Account
    {
        public string UserName { get; private set; }
        public int IdAccount { get; private set; }
        public double Balance { get; private set; }

        public Account()
        {

        }

        public Account(int idAccount, string userName, double deposit)
        {
            UserName = userName;
            IdAccount = idAccount;
            AddMoney(deposit);
        }

        public override string ToString()
        {
            return $"Account {IdAccount} user {UserName} balance {Balance.ToString("F2", CultureInfo.CurrentCulture)}";
        }

        public void AddMoney(double deposit)
        {
            Balance += deposit;
        }

        public void TakeMoney(double withdrawMoney)
        {
            Balance -= withdrawMoney;
        }
    }
}
