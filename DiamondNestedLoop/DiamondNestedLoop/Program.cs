﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * C# Program to Print the Sum of all the Multiples of 3 and 5
 */

namespace DiamondNestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i, k, count = 1;
            Console.WriteLine("Enter number of rows\n");
            number = int.Parse(Console.ReadLine());
            count = number - 1;

            for (k = 1; k <= number; k++) 
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                 count--;

                for (i = 1; i <= 2 * k -1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
