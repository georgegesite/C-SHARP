using System;

namespace Methods
{
    class Program
    {
        static string name = "Flora Mae";
        static bool isOnline = false;
        static void Main(string[] args)
        {
            Greet();
            Console.WriteLine(Addition(100, 2));
            Console.WriteLine(Addition(100, 2, 3));
            int[] array = { 1, 2, 3, 5 };
            Console.WriteLine(Summation(array));
        }

        static int Addition(int x, int y)
        {
            return x + y;
        }
        //Overloading the Addition Method
        static int Addition(int x, int y, int z)
        {
            return x + y + z;
        }
        static int Summation(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;

        }

        static void Greet()
        {
            if (isOnline)
            {
                Console.WriteLine($"{name} is awake and kicking.");
            }
            else
            {
                Console.WriteLine($"{name} is asleep.");
            }
        }
    }
}