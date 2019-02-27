using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3=0;

            Console.WriteLine("Please enter 2 numbers");
            Console.WriteLine("Please enter your first number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            num2=Convert.ToInt32(Console.ReadLine());
            num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine("You have swapped the values");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.ReadLine();


        }
    }
}
