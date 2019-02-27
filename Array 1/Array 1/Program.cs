using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] limit = new int[0];
            limit=Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int repeat = 1; repeat <= limit.Length; repeat++)
            {

                limit[repeat - 1] = random.Next(9);
                Console.Write(limit[repeat - 1] + " ");
                if (repeat % 10 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
