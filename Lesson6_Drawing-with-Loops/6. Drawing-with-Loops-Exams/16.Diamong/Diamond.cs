using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Diamong
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int height = 3 * n + 2;
            int leftRightDots = n;
            int middleDots = width - 2 * leftRightDots - 2;
            Console.WriteLine("{0}{1}{0}", new string('.', leftRightDots), new string('*', middleDots + 2));

            for (int row = 0; row < n-1; row++)
            {
                leftRightDots--;
                middleDots += 2;
                Console.WriteLine("{0}*{1}*{0}", new string('.', leftRightDots), new string('.', middleDots));
            }
            Console.WriteLine(new string('*', width));
            for (int row = 0; row < 2 * n; row++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', leftRightDots), new string('.', middleDots));
                leftRightDots++;
                middleDots -= 2;
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', leftRightDots), new string('*', middleDots));
        }
    }
}
