using System;
using System.Globalization;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Times: ");
            int n = int.Parse(Console.ReadLine());

            //double[] vect = new double[n];
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.Write("Product Name: ");
                string name = Console.ReadLine();

                Console.WriteLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine();
            Console.WriteLine($"Total is: R$ {sum.ToString("F2", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Avarage is: R$ {avg.ToString("F2", CultureInfo.CurrentCulture)}");
        }
    }
}
