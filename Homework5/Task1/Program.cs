using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the matrix length: ");
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            Random rand = new Random();

            int[,] matrix = new int[rows, colums];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(0, 100);
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("|{0}| \t", matrix[i, j]);
                    
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] % 2 == 0)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                }
            }
        }
    }
}
