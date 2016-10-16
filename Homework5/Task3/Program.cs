using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter number b (b>a): ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (b > a)
            {
                for (int i = a; i < b; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("B is not bigger than a");
            }
        }
    }
}
