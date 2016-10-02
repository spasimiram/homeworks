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
            Console.WriteLine("Write your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Write your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Your name is: " + firstName + "_" + lastName);
        }
    }
}
