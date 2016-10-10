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

            for (int a = 1; a <= 100; a++)
            {
                if (a % 3 != 0 || a % 7 != 0)
                {
                    Console.WriteLine(a);
                }

            }

        }
    }
}
