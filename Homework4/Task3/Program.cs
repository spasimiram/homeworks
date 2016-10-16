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
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = i * 10;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
