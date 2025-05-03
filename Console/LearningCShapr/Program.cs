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

            if(EMPTY_STRING.Equals("123")){
                Console.WriteLine("is equal");
            } else {
                Console.WriteLine("not equal");
            }
        }
    }
}