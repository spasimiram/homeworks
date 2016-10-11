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
            Console.WriteLine("enter one number K: ");
            int K = int.Parse(Console.ReadLine());
            decimal bigInt1 = 1;
            decimal bigInt2 = 1;
            Console.WriteLine("enter another number. N should be bigger than K: ");
            int N = int.Parse(Console.ReadLine());
            if ((N > K) && (N > 1) && (K > 1))
            {
                while (K > 1)
                {
                    bigInt1 *= K;
                    K--;
                }
                Console.WriteLine("K! = {0}", bigInt1);

                {
                    do
                    {
                        bigInt2 *= N;
                        N--;
                    }
                    while (N > K);

                }
                Console.WriteLine("N! = {0}", bigInt2);

                Console.WriteLine("N! / K! is: " + (bigInt2 / bigInt1));

            }
            else
            {
                Console.WriteLine("Not a valid entry");
            }



        }
    }
}
