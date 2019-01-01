using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftDashes = 3 * n;
            int rightDashes = n - 1;

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', row), new string('-', 2 * rightDashes - row));
            }
            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine("{0}{1}*{2}", new string('*', leftDashes + 1), new string('-', rightDashes), new string('-', rightDashes));
            }
            for (int row = 0; row < n / 2; row++)
            {
                if (row == n / 2 - 1)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes - row), new string('*', rightDashes + 2 * row), new string('-', rightDashes - row));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes - row), new string('-', rightDashes + 2 * row), new string('-', rightDashes - row));
                }
            }
        }
    }
}
