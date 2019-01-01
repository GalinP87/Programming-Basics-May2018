using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Rhombus_of_Stars
{
    class RhombusofStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int spaces = 0; spaces < n - row; spaces++)
                {
                    Console.Write(' ');
                }
                for (int col = 0; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int row = 1; row < n; row++)
            {
                for (int spaces = 0; spaces < row; spaces++)
                {
                    Console.Write(' ');
                }
                for (int stars = 0; stars < n - row; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
