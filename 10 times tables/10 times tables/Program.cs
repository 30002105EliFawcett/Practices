using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_times_tables
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            Console.WriteLine("Please Enter a Number between 0-10");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n2 +" Timestables");

            for (n1 = 1; n1 <= 10; n1++)
            {
                Console.Write(n2*n1);
            }

            Console.ReadLine();
        }
    }
}
