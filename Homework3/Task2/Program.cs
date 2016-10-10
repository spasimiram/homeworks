using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter one number:");
            
            int N = int.Parse(Console.ReadLine());

            for (int a = 1; a <= N; a++)
            {
                if (a % 3 != 0 || a % 7 != 0)
                {
                    Console.WriteLine(a);
                }

            }

        }
    }
}
