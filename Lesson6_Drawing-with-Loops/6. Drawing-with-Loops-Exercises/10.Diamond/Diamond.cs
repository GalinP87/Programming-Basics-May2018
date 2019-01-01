using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftRight = (n - 1) / 2;
            for (int row = 0; row < (n - 1) / 2; row++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write('*');
                int mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight--;
            }
            for (int row = 0; row < (n + 1) / 2; row++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write('*');
                int mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight++;
            }
        }
    }
}
