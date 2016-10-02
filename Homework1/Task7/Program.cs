using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write two words");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (b.Contains(a))
            {
                Console.WriteLine("Your second word contains your first word");
            }
            else 
            {
                Console.WriteLine("Your second word does not contain your first word");
            }
        }
    }
}
