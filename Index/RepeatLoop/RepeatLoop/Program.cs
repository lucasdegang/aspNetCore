using System;

namespace RepeatLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Estefani", "Otto", "Lucas" };

            Console.WriteLine("##### Foreach #####");

            foreach (string obj in names)
            {
                Console.WriteLine($"current name {obj}");
            }

            Console.WriteLine();

            Console.WriteLine("##### For in #####");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"current name {names[i]}");
            }
        }
    }
}
