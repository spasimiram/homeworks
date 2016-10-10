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
            int zero = 0;
            decimal bigInt = 1;
            int a = int.Parse(Console.ReadLine());
            while (a > 0)
            {
                bigInt *= a;
                a--;
            }
            Console.WriteLine(bigInt);

            ab:
            if(bigInt % 10 == 0)
            {
                bigInt = bigInt / 10;
                zero++;
                goto ab;

            }
            else 
            {
                Console.WriteLine("Zeros are: " + zero);
            }
            

        }
    }
}

