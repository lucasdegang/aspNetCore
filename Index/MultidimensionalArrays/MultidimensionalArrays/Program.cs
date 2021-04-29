using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Length, Rank, GetLength

            // instance of 2 lines and 3 cols 
            double[,] mat = new double[2, 3];

            Console.WriteLine($"Lenght {mat.Length}"); // todos os campos 
            Console.WriteLine($"Rank {mat.Rank}"); // primeira dimensao da matriz, qtd linhas
            Console.WriteLine($"Lenght {mat.GetLength(0)}"); // primeira dimensao da matriz = linha
            Console.WriteLine($"Lenght {mat.GetLength(1)}"); // segunda dimesao da matriz = coluna

            Console.WriteLine("--------------------------");

            int matrixLength = 0
              , count = 0;

            Console.WriteLine("Matrix length: ");
            matrixLength = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixLength, matrixLength];

            // lines
            for (int i = 0; i < matrixLength; i++)
            {
                Console.WriteLine("Write values of the matrix like [num<space>num<space>num<space>n...] : ");
                string[] values = Console.ReadLine().Split(' ');

                // cols
                for (int j = 0; j < matrixLength; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("--------- Output ---------");

            // diagonal
            Console.WriteLine();
            Console.WriteLine("Diagonal");
            for (int i = 0; i < matrixLength; i++)
            {
                Console.WriteLine($"   {matrix[i, i]}");
            }

            // Negative numbers
            Console.WriteLine();
            Console.WriteLine("Negative numbers");
            for (int i = 0; i < matrixLength; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"   count: {count}");

            count = 0;

            // Positive numbers
            Console.WriteLine();
            Console.WriteLine("Positive numbers");
            for (int i = 0; i < matrixLength; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"   count: {count}");
        }
    }
}
