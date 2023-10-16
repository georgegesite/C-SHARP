using System;

class Program
{
    public static int Null { get; private set; }

    static void Main()
    {
        // Variables are statically typed in 

        Console.WriteLine("Hello World");
        Console.WriteLine("Hello World");
        String name = "George";
        Console.WriteLine("Hello " + name);

        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(count);
            count++;
        }
    }
}
