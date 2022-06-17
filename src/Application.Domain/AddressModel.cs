namespace Application.Domain
{
    public class AddressModel : BaseModel
    {
        private long PostalCode { get; set; }
        private string Address { get; set; }
        private int Number { get; set; }
        private string Complement { get; set; }

        public void SetPostalCode(long postalCode)
        {
            this.PostalCode = postalCode;
        }

        public void SetAddress(string address, int number, string complement)
        {
            this.Address = address;
            this.Number = number;
            this.Complement = complement;
        }
        public AddressModel GetObject()
        {
            return this;
        }

        public override string ToString()
        {
            return $"this is the Address Object values: \n {this}";
        }
    }
}