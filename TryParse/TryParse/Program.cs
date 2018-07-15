using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            // See if we can parse the 'text' string.
            // If we can't, TryParse will return false.
            // Note the "out" keyword in TryParse.
            string text1 = "x";
            int num1;
            bool res = int.TryParse(text1, out num1);

            if (res == false)
            {
                Console.WriteLine("String is not a number");
            }

            // Use int.TryParse on a valid numeric string.
            string text2 = "100";
            int num2;
            if (int.TryParse(text2, out num2))
            {
                Console.WriteLine("Assigned");
            }

            // Display both results.
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }

    // C# program that uses int.TryParse, with no if
    //class Program
    //{
    //    static void Main()
    //    {
    //        string error = "Welcome";
    //        // This will leave the result variable with a value of 0.
    //        int result;
    //        int.TryParse(error, out result);
    //        Console.WriteLine(result);
    //    }
    //}

    //C# program that uses TryParse, new out syntax

    //class Program
    //{
    //    static void Main()
    //    {
    //        const string value = "345";
    //        // We can place the "out int" declaration in the method call.
    //        if (int.TryParse(value, out int result))
    //        {
    //            Console.WriteLine(result + 1);
    //        }
    //    }
    //}

    //C# program that uses Convert.ToInt32

    //class Program
    //{
    //    static void Main()
    //    {
    //        // Convert "text" string to an integer with Convert.ToInt32.
    //        string text = "500";
    //        int num = Convert.ToInt32(text);
    //        Console.WriteLine(num);
    //    }
    //}

    //C# program that times int parse methods

    //    class Program
    //{
    //    public static int IntParseFast(string value)
    //    {
    //        // An optimized int parse method.
    //        int result = 0;
    //        for (int i = 0; i < value.Length; i++)
    //        {
    //            result = 10 * result + (value[i] - 48);
    //        }
    //        return result;
    //    }

    //    const int _max = 1000000;
    //    static void Main()
    //    {
    //        // Test the methods.
    //        Console.WriteLine(IntParseFast("123456"));
    //        Console.WriteLine(int.Parse("123456"));

    //        var s1 = Stopwatch.StartNew();
    //        for (int i = 0; i < _max; i++)
    //        {
    //            int result = IntParseFast("123456");
    //        }
    //        s1.Stop();
    //        var s2 = Stopwatch.StartNew();
    //        for (int i = 0; i < _max; i++)
    //        {
    //            int result = int.Parse("123456");
    //        }
    //        s2.Stop();
    //        Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
    //            _max).ToString("0.00 ns"));
    //        Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
    //            _max).ToString("0.00 ns"));
    //        Console.Read();
    //    }
    //}

    //C# program that calls TryParse on DateTime
    
    //class Program
    //{
    //    static void Main()
    //    {
    //        string now = "1/22/2017";
    //        // Use TryParse on the DateTime type to parse a date.
    //        DateTime parsed;
    //        if (DateTime.TryParse(now, out parsed))
    //        {
    //            Console.WriteLine(parsed);
    //        }
    //    }
    //}


}
