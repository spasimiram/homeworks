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
            Console.WriteLine("Enter the array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
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
            int temp = 0;
            for (int i = 0; i < array.Length/2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            foreach (var item in array)
            {
                Console.Write("|{0}|", item);
            }
        }
    }
}
