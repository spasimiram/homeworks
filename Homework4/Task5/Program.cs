using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] array2 = new int[n];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("|{0}|", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            foreach (var item in array2)
            {
                Console.Write("|{0}|", item);
            }
        }
    }
}
