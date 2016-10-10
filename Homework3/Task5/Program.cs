using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one number:");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;

            while (a != 0)
            {
                Console.WriteLine("Next number: ");
                int nextNumber = int.Parse(Console.ReadLine());
                if (nextNumber != 0)
                {
                    sum += nextNumber;
                    Console.WriteLine("The sum is: " + (sum + a));
                }
                else
                {
                    break;
                }
              
            }
            
        }
    }
}