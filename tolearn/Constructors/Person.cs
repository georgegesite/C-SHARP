using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        public int age { get; set; }
        public char sex { get; set; }
        public string firstName { get; set; }
        public string  lastName { get; set; }

        public Person(string firstName, string lastName, int age, char sex)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.sex = sex;
            Console.WriteLine("Person Created");
             
        }
    }
}
