using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times
{
    class Program
    {
        static void Main(string[] args)
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
