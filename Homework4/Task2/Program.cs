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
            Console.WriteLine("Enter the array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array[0] = 0;
            array[1] = 1;

            for (int i = 2; i < array.Length; i++)
            {
                
                array[i] = array[i - 1] + array[i-2];    
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
