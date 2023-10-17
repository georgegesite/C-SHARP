using System;

class Program
{
    public static int Null { get; private set; }

    static void Main()
    {
        // Variables are statically typed in 

        // Console.WriteLine("Hello World");
        // Console.WriteLine("Hello World");
        // String name = "George";
        // Console.WriteLine("Hello " + name);

        // int count = 0;
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(count);
        //     count++;
        // }

        //Testing Floats ( can add float and double)
        // float value = 3.14f; //float data type must have f suffix
        // double value2 = 3.14;
        // Console.WriteLine(value);
        // Console.WriteLine(value2);
        // Console.WriteLine(value + value2);

        //Booleans
        //     bool isValidated = false;
        //     if (isValidated) Console.WriteLine("valid");
        //     else Console.WriteLine("not valid");

        //     //integer
        //     int hundred = 100;
        //     long thousand = 1000;
        //     Console.WriteLine(hundred + thousand);

        //     //String
        //     string greeting = "Hello world";
        //     Console.WriteLine(greeting + " and Hello George");

        //     //Datetime type
        //     DateTime currentDate = DateTime.Now;
        //     Console.WriteLine(currentDate);

        // ReadLine and ReadKey
        Console.Write("Enter your name: ");
        string name = Console.ReadLine(); // Reads a line of characters from the console

        if (!string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Hello, " + name);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid name.");
        }

        int numInt = 10;
        double numDouble = numInt; // Implicit conversion

        double numDouble2 = 15.75;
        int numInt2 = (int)numDouble2; // Explicit casting

        Console.WriteLine("Converted Double: " + numDouble);
        Console.WriteLine("Casted Int: " + numInt2);
    }
}
