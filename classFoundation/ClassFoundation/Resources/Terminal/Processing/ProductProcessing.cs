using System;
using System.Globalization;

namespace ClassFoundation.Processing
{
    public class ProductProcessing
    {
        public void Processing()
        {
            Console.WriteLine("### Product Cadaster");

            Console.WriteLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            Console.WriteLine();
            Console.Write("Stock: ");
            int qtdStock = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Product Add Stock Quantity: ");
            int addQtdStock = int.Parse(Console.ReadLine());

            // class instance
            
            //Product p = new Product(name, price, qtdStock);
            Product p = new Product
            {
                Name = name,
                Price = price,
                Quantity = qtdStock
            };

            p.ProductAdd(addQtdStock);

            Console.WriteLine();
            //Console.WriteLine($"Product updated {p}");
            Console.WriteLine($"{p.ToString()}");

            Console.WriteLine();
            Console.Write("Product Remove Stock Quantity: ");
            int removeQtdStock = int.Parse(Console.ReadLine());
            p.ProductRemove(removeQtdStock);

            Console.WriteLine();
            //Console.WriteLine($"Product updated {p}");
            Console.WriteLine($"{p.ToString()}");
        }
    }
}

