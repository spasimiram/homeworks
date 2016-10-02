using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The remainder is: " + (a % b));
        }
    }
}
