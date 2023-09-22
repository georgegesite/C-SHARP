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
    }
}
