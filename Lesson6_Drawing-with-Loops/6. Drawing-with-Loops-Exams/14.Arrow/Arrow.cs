using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRightWidth = (n - 1) / 2;
            string leftRightDots = new string('.', leftRightWidth);
            int middleWidth = n;

            Console.WriteLine("{0}{1}{0}", leftRightDots, new string('#', middleWidth));
            middleWidth -= 2;

            for (int row = 1; row < n - 1; row++)
            {
                Console.WriteLine("{0}#{1}#{0}", leftRightDots, new string('.', middleWidth));
            }

            leftRightWidth++;
            Console.WriteLine("{0}{1}{0}", new string('#', leftRightWidth), new string('.', middleWidth));

            for (int row = 1; row < n - 1; row++)
            {
                leftRightWidth = row;
                middleWidth = 2 * (n - row) - 3;
                Console.WriteLine("{0}#{1}#{0}", new string('.', leftRightWidth), new string('.', middleWidth));
            }

            Console.WriteLine("{0}#{0}", new string('.', leftRightWidth + 1));
        }
    }
}
