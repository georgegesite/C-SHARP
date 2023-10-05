using System;

class Program
{
    public static int Null { get; private set; }

    static void Main()
    {
        // Variables are statically typed in C#
        int n = 0;
        Console.WriteLine("n = " + n); // n = 0

        string m = "abc";
        Console.WriteLine("m = " + m); // m = abc

        // Multiple assignments
        int n1 = 0;
        string m1 = "abc";
        double z = 0.125;
        string m2 = "abc";
        bool z2 = false;

        // Increment
        n = n + 1; // good
        n += 1;    // good
        // In C#, you can use the "++" operator for incrementing
        n++;       // also good

        // "null" in C# is equivalent to "null" in JavaScript (represents the absence of a value)
        int n3 = 4;
        n3 = Null;
        Console.WriteLine("n3 = " + n3); // n3 = null

        // If else Statements
        int n = 1; // Initialize variable n with the value 1

        // If statement without curly braces for single statements
        if (n > 2)
            n -= 1; // Subtract 1 from n if n is greater than 2
        else if (n == 2)
            n *= 2; // Multiply n by 2 if n is equal to 2
        else
            n += 2; // Add 2 to n otherwise

        int m = 2; // Initialize variable m with the value 2

        // Complex condition with parentheses for readability
        if ((n > 2 && n != m) || n == m)
        {
            n += 1; // Add 1 to n if the condition is true
        }

        Console.WriteLine("n = " + n);

        Console.WriteLine("Hello World");
        Console.WriteLine("Hello World");
    }
}
