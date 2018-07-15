using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Jenny";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;

            // implicit type in action

            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int y = 1;
            byte c = (byte)i;  // max in a byte is 255, if you assign 1000 in y some data will be lost
            Console.WriteLine(c);

            string number2 = "1234";
            int v = Convert.ToInt32(number2);
            Console.WriteLine(v);

            /*
            // overflow exception
            string number3 = "1234";
            byte by = Convert.ToByte(number3);
            Console.WriteLine(by);
            */

            // handle exception so program won't crash

            try
            {
                string number3 = "1234";
                byte by = Convert.ToByte(number3);
                Console.WriteLine(by);
            }
            catch (Exception)
            {
                Console.WriteLine("the number could not be converted to a byte.");
            }

            // Another exception example

            try
            {
                string str = "true";
                bool ba = Convert.ToBoolean(str);
                Console.WriteLine(ba);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            // operators
            var d = 1;
            var e = 2;
            var f = 3;

            Console.WriteLine(d / e);
            Console.WriteLine((float)d / (float)e);

            // operator precedence
            Console.WriteLine(d + e * f);

            // comparison operator
            Console.WriteLine(d > e);
            Console.WriteLine(d == e);
            Console.WriteLine(!(d != e));

            // logical operator
            Console.WriteLine(f > e && f == d);
            Console.WriteLine(!(f > e || f == d));

        }
    }
}
