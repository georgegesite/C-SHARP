using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
         // Access Modfiers
         // - default or private
         // - public
         // - internal
         // - protected

        //Static Methods, Variables & Classes

        static void Main(string[] args)
        {
            Console.WriteLine(Arithmetic.Subtraction(5, 2));
            Console.WriteLine(Arithmetic.Addition(1, 2));
            Console.WriteLine(Constants.PI);
            Console.ReadKey();
        }
    }
}
