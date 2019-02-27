using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int answer;
            Console.WriteLine("Please Enter First Number");
            firstNumber =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            answer = firstNumber / secondNumber;
            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
