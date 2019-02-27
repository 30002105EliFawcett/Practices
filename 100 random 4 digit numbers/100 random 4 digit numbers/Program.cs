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
            int[] limit = new int[100];
            Random random = new Random();
            for (int repeat = 1; repeat <= limit.Length; repeat++)
            {

                limit[repeat-1] = random.Next(1000, 9999);
                Console.Write(limit[repeat - 1] + " ");
                if(repeat%10== 0)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
