using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * C# Program to Get a Number and Display the Number with its Reverse
 */

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;

            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            while(num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }

            Console.WriteLine("Reverse of entered number is: "+reverse);
            Console.ReadLine();
        }
    }
}
