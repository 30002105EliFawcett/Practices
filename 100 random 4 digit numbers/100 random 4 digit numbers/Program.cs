using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_random_4_digit_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 100;

            Random random = new System.Random();
            int value = random.Next(1000, 9999);
            Console.WriteLine(value);
            Console.ReadLine();
            for (value = 1000; value <= limit; value++);
            {
                Console.WriteLine(value);
            }
        }
    }
}
