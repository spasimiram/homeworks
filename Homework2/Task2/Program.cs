﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your bonus points. You should have between 1 and 9 points");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Your result is: " + (a * 5));
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Your result is: " + (a * 10));
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Your result is: " + (a * 50));
                    break;
                default:
                    Console.WriteLine("Invalid points!");
                    break;
            }
        }
    }
}
