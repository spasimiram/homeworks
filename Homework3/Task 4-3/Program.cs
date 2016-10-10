using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1;
            do
            {
                if (a % 3 != 0 || a % 7 != 0)
                {
                    Console.WriteLine(a);
                }
                a++;
            }
            while (a <= 100 );
        }
    }
}
