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
            Console.WriteLine("Enter one of the cards from the deck");
            string a = Console.ReadLine();
            switch (a)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "K":
                case "Q":
                case "A":
                    Console.WriteLine("Valid card");
                    break;
                default:
                    Console.WriteLine("Invalid card");
                    break;
            }

        }

    }
}
