using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter one number K: ");
            int K = int.Parse(Console.ReadLine());
            decimal bigInt1 = 1;

            while (K > 1)
            {
                bigInt1 *= K;
                K--;
            }
            Console.WriteLine("K! = {0}", bigInt1);

            Console.WriteLine("enter another number: ");
            decimal bigInt2 = 1;
            int N = int.Parse(Console.ReadLine());
            while (N > 1)
            {
                bigInt2 *= N;
                N--;
            }
            Console.WriteLine("N! = {0}", bigInt2);

            decimal bigInt3 = 1;
            int a = (N - K);
            while ((N > 1) && (K > 1))
            {
                bigInt3 *= a;

            }

            Console.WriteLine("(N!*K!)/(N-K)! is: " + (bigInt2 * bigInt1) / bigInt3);

        }
    }
}
