namespace Application.Commands.Exercises.Bank.Models
{
    public class BankAccount : BaseModel
    {
        public BankAccount(int id, string name, string passPort, string nationality, Address address, double balance, string currency) 
            : base(id)
        {
            Name = name;
            PassPort = passPort;
            Nationality = nationality;
            Address  = address;
            Balance = balance;
            Currency = currency;
        } 
        public string Name { get; set; }

        public string PassPort { get; set; }

        public string Nationality { get; set; }

        public Address Address { get; set; }

        public double Balance { get; set; }

        public string Currency { get; set; }

        public static void AccountValidator(int id, string name, string passPort, string nationality, 
            Address address, double balance, string currency)
        {
            if (id.Equals(null))
            {
                throw new Exception($"Exercise>Bank>BankAccount>AccountValidator id is nok");
            }

            if (name.Equals(null) || name.Equals(string.Empty))
            {
                throw new Exception($"Exercise>Bank>BankAccount>AccountValidator name is nok");
            }

            if (passPort.Equals(null) || passPort.Equals(string.Empty))
            {
                throw new Exception($"Exercise>Bank>BankAccount>AccountValidator passPort is nok");
            }

            if (nationality.Equals(null) || nationality.Equals(string.Empty))
            {
                throw new Exception($"Exercise>Bank>BankAccount>AccountValidator nationality is nok");
            }

            if (balance.Equals(null) || currency.Equals(string.Empty))
            {
                throw new Exception($"Exercise>Bank>BankAccount>AccountValidator double value(s) is nok");
            }
        }
    }
}
