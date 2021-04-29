using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int m , n ;

            Console.WriteLine();
            Console.Write("Lines: ");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Cols: ");
            n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine();
                Console.Write("Write values of the matrix like [num<space>num<space>num<space>n...] : ");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Number to know about: ");
            int x = int.Parse(Console.ReadLine());

            // reading each occurs
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // element equal to know about
                    if (matrix[i, j] == x)
                    {
                        Console.WriteLine($"Position {i},{j}");

                        // col left
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matrix[i, j - 1]);
                        }

                        // col right
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + matrix[i, j + 1]);
                        }

                        // up
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matrix[i - 1, j]);
                        }

                        // down
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + matrix[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
