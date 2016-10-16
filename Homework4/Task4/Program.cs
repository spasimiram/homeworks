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
            Console.WriteLine("Enter the length of the array:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("The numbers are:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("|{0}|", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Enter one number from the array: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (a == array[i])
                {
                    Console.WriteLine("The index is " + i);
                    break;
                }
            }

        }
    }
}
