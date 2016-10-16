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
            Console.WriteLine("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            bool isSymetric = true;

            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    isSymetric = false;
                    break;
                }
            }
            Console.WriteLine("The array is symetric: " + isSymetric);
        }
    }
}
