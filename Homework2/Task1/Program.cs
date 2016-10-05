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
            Console.WriteLine("Write a number between 1 and 9");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("One");
            }
            else if (a == 2)
            {
                Console.WriteLine("Two");
            }
            else if (a == 3)
            {
                Console.WriteLine("three");
            }
            else if (a == 4)
            {
                Console.WriteLine("Four");
            }
            else if (a == 5)
            {
                Console.WriteLine("Five");
            }
            else if (a == 6)
            {
                Console.WriteLine("Six");
            }
            else if (a == 7)
            {
                Console.WriteLine("Seven");
            }
            else if (a == 8)
            {
                Console.WriteLine("Eight");
            }
            else if (a == 9)
            {
                Console.WriteLine("Nine");
            }
            else
            {
                Console.WriteLine("The number is either less than 1 or bigger than 9");
            }
        }
    }
}
