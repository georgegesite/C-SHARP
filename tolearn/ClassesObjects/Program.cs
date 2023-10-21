using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person George = new Person(); //Class Instantiation
            George.firstName = "George"; //Declare property
            George.lastName = "Gesite";
            George.age = 22;
            George.sex = 'M';


            Console.WriteLine(George.firstName); //Access Property
            Console.ReadKey();
        }
    }
}
