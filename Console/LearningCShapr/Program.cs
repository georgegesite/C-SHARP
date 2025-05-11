using System;

namespace HelloWorld
{
    class Program
    {

        public static string EMPTY_STRING = "";
        static void Main(string[] args)
        {

            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String

            Console.WriteLine(myText);

            float f1 = 35e3F;
            float f2 = 35E3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(d1);

            if (EMPTY_STRING.Equals("123"))
            {
                Console.WriteLine("is equal");
            }
            else if ("Hello".Equals(myText))
            {
                Console.WriteLine("Hello is equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }


            // Ternary Operators
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            Console.WriteLine(calculateDay(7));
        }

        public static string calculateDay(int day)
        {
            string dayStr = EMPTY_STRING;
            switch (day)
            {
                case 1:
                    dayStr = "Monday";
                    break;
                case 2:
                    dayStr = "Tuesday";
                    break;
                case 3:
                    dayStr = "Wednesday";
                    break;
                case 4:
                    dayStr = "Thursday";
                    break;
                case 5:
                    dayStr = "Friday";
                    break;
                case 6:
                    dayStr = "Saturday";
                    break;
                case 7:
                    dayStr = "Sunday";
                    break;
            }
            return dayStr;
        }
    }
}