using System.Globalization;

namespace ClassFoundation
{
    public class Product
    {
        // constructor - sobrecarga/ overload
        public Product() { }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalPriceInStock()
        {
            return Price * Quantity;
        }

        public void ProductAdd(int quantity)
        {
            Quantity += quantity;
        }

        public void ProductRemove(int quantity)
        {
            Quantity -= quantity;
        }

        // convert the object <Product> in string
        public override string ToString()
        {

            return $"Product name {Name} price R$ {Price.ToString("F2", CultureInfo.CurrentCulture)} quantities in unity {Quantity} ";
        }

        // attributes
        public string Name;
        public double Price;
        public int Quantity;
    }
}
