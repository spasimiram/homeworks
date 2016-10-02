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
            Console.WriteLine("Enter one integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another one integer: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is: " + (a + b));
        }
    }
}
