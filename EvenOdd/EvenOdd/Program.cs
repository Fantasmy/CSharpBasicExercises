using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter a number: ");
            x = int.Parse(Console.ReadLine());

            if (x % 2 ==0)
            {
                Console.WriteLine("Enteres number is an even number");
                Console.Read();
            }

            else
            {
                Console.WriteLine("Entered number is an odd number");
                Console.Read();
            }

        }
    }
}
