using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person George = new Person("George", "Gesite", 22, 'M');

            Console.WriteLine(George.firstName);
            Console.WriteLine(George.lastName);
            Console.WriteLine(George.age);
            Console.WriteLine(George.sex);

            Console.ReadKey();

        }
    }
}
