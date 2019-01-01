using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * (n - 2) + 1;
            int sideWidth = n - 1;
            string stars = new string('*', n - 2);
            string dashes = new string('-', n - 2);
            string upMid = @"\ /";
            string downMid = @"/ \";

            for (int rows = 0; rows < n - 2; rows++)
            {
                if (rows % 2 == 0)
                {
                    Console.WriteLine(stars + upMid + stars);
                }
                else
                {
                    Console.WriteLine(dashes + upMid + dashes);
                }
            }
            Console.WriteLine(new string(' ', n - 1) + '@' + new string(' ', n - 1));
            for (int rows = 0; rows < n - 2; rows++)
            {
                if (rows % 2 == 0)
                {
                    Console.WriteLine(stars + downMid + stars);
                }
                else
                {
                    Console.WriteLine(dashes + downMid + dashes);
                }
            }
        }
    }
}
