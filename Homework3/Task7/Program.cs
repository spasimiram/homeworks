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

            while (K > 1)
            {
                bigInt1 *= K;
                K--;
            }
            Console.WriteLine("K! = {0}", bigInt1);


            Console.WriteLine("enter one number. N should be bigger than K: ");
            decimal bigInt2 = 1;
            int N = int.Parse(Console.ReadLine());
            if ((N > K) && (N>1) && (K>1))
            {
                do
                {
                    bigInt2 *= N;
                    N--;
                }
                while (N > K);
            }
            else {
                Console.WriteLine("Not a valid entry");
                    }
            
                       
            Console.WriteLine("N! = {0}", bigInt2);

            Console.WriteLine("N! / K1 is: " + (bigInt2 / bigInt1));

        }
    }
}
