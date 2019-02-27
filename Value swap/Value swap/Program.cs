using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int swap;

            Console.WriteLine("Please enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            SwapInts(num1 num2);

        }
    }
}
