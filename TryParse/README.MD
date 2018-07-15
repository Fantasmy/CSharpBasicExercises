# Project: TryParse examples

One Paragraph of project description goes here

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

Visual Studio installed.

### Installing

Run the program with Ctr+F5

## Built With

* Visual Studio 2017

## Information about parsing int (int.Parse, int.TryParse)

A string, when parsed, can be represented as another type like int. 
The word "int" in the C# language simply aliases the System.Int32 type.
"System.Int32.Parse" or "System.Int32.TryParse" is equivalent to int.Parse and int.TryParse.
In projects where speed is an issue (which is common), I take the time to add an optimized method like IntParseFast below.

Floating-point: If the input has many digits or decimal places, use double.Parse or double.TryParse.

Other types. Numbers can be smaller than an int (like a byte) or much larger (like a decimal). Each type has a useful Parse and TryParse method.
        bool.Parse
        decimal.Parse
        double.Parse
        long.Parse

* int.Parse:
- Parse() throws exceptions on invalid input. This can be slow if errors are common.
Note: Parse() is a static method we access on the int type. It returns an integer upon success.
- The int.Parse method is strict. With an invalid string, it throws a FormatException. We can catch this using a try-catch construct.

* int.TryParse:
- Using the int.TryParse method is usually a better solution. TryParse is faster.
- The parsing logic in TryParse is the same. But the way we call it is different.
- TryParse uses somewhat more confusing syntax. It does not throw exceptions.
- You must describe the second parameter with the out modifier. TryParse also returns true or false based on its success (eg: bool res = int.TryParse(text1, out num1);).
- We must use out before the second argument in int.TryParse. With "out", the compiler can help you make sure your variables are always in a valid state.

    * TryParse with no if:
    - Usually we call int.TryParse inside an if-statement. But this is not required. And sometimes, we can just treat a failed parse as the default value (0 for int).
    - This removes a branch in our code—we can just use the result, not test it. Branches are good for trees, but bad for performance.

    * TryParse, new out syntax: 
    - We can place the "out int" keywords directly inside a method call. Older versions of C# do not allow this syntax. But this can reduce the line count of a program.

    * Convert:
    - Convert.ToInt32 (along with its siblings Convert.ToInt16 and Convert.ToInt64) is a static wrapper method for the int.Parse method.
    - Warning: ToInt32 can be slower than int.Parse if the surrounding code is equivalent.
    - Confusing:The syntax here may be more confusing. It uses the bit size of the int, which may not be relevant to the code's intent.

    * DateTime:
    - We can parse a string into a DateTime type with TryParse. Parsing methods on DateTime use a similar syntax.


## Acknowledgments

* See the source: https://www.dotnetperls.com/parse
