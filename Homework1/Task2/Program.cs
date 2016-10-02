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
            Console.WriteLine("Enter one greeting word: ");
            string a = Console.ReadLine();
            string b = "Hello";
            Console.WriteLine("Is your greeting word Hello? " + (a==b));
        }
    }
}
