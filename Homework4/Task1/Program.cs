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
            Console.WriteLine("Enter the array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}:{1}", i + 1, array[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine("The sum of all even numbers is: " + sum);
        }
    }
}
