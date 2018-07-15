using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * C# Program to Swap two Numbers
 */

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.WriteLine("\nEnter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.Write("\nAfter swaping: ");
            Console.Write("\nFirst number: " +num1);
            Console.Write("\nSecond number: "+num2);
            Console.Read();

        }
    }
}
