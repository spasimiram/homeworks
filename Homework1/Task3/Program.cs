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
            Console.WriteLine("We will find the area of a right treangle: ");
            Console.WriteLine("Enter the base and the height of the treangle: ");
            Console.WriteLine("The base is: ");
            int triangleBase = int.Parse(Console.ReadLine());
            Console.WriteLine("The height is: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("The area is: " + ((triangleBase + height) / 2));
        }
    }
}
