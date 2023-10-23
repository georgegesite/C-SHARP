using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle();
            double area = circle.CalculateArea(5);
            Console.WriteLine($"Area of the circle: {area}");

            Console.ReadKey();
        }
    }
}
