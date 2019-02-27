using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radius
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double area;
            double perimeter;
            double pi = 3.141592653;

            Console.WriteLine("Please Enter The Radius");
            num1 = Convert.ToDouble(Console.ReadLine());
            perimeter = (2 * pi * num1);
            area = (pi * num1 * num1);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.ReadLine();
            

        }
    }
}
