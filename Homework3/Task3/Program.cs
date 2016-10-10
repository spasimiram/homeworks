using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("set the number of numbers = ");
            int n = int.Parse(Console.ReadLine());
            int counter;
            int maxNumber = 0;
            int minNumber = Int32.MaxValue;

            for (counter = 0; counter < n; counter++)
            {
                Console.Write("next number: ");
                int nextNumber = int.Parse(Console.ReadLine());
                if (minNumber > nextNumber)
                {
                    minNumber = nextNumber;

                }
                if (maxNumber < nextNumber)
                {
                    maxNumber = nextNumber;
                }

            }
            Console.WriteLine("max= " + maxNumber);
            Console.WriteLine("min= " + minNumber);



        }
    }
}
