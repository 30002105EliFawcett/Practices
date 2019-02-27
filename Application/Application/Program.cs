using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            void Radius()
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
            void Adding()
            {
                int first;
                int second;
                int answer;

                second = 20;
                first = 10;
                Console.WriteLine(first);
                Console.WriteLine(second);
                answer = first + second;
                Console.WriteLine(answer);
            }
            void Times()
            {
                int number1;
                int number2;
                int answer;
                Console.WriteLine("Please Enter Your First Number");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Your Second Number");
                number2 = Convert.ToInt32(Console.ReadLine());

                answer = number1 * number2;
                Console.WriteLine("The Answer Is");
                Console.WriteLine(answer);
                Console.ReadLine();
            }
        }
    }
}
