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
            Console.Write("Enter one number:");
            int a = 1;
            int N = int.Parse(Console.ReadLine());
            while(a<=N)
            {
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
