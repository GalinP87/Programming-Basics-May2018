using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Point_in_the_Figure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool inside1 = ((h < x && x < 2 * h) && (h < y && y < 4 * h));
            bool inside2 = ((0 < x && x < 3 * h) && (0 < y && y < h));
            bool insideMiddle = ((h < x && x < 2 * h) && y == h);
           
            if (inside1 || inside2 || insideMiddle)
            {
                Console.WriteLine("Inside");
            }
            else if ((x < 0 || x > 3 * h) 
                || (y < 0 || y > 4 * h)
                || ((x < h || x > 2 * h) && (h < y)))
            {
                Console.WriteLine("Outside");
            }
            else
            {
                Console.WriteLine("Border");
            }
        }
    }
}
