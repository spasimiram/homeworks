using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write  a real number:");
            double doublea = double.Parse(Console.ReadLine());
            int intb = 5;
            double c = doublea / intb;
            Console.WriteLine("Your number/5 is: " + c);
        }
    }
}
