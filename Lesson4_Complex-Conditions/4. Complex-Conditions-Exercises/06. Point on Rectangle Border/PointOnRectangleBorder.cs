using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Point_on_Rectangle_Border
{
    class PointOnRectangleBorder
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isOnBorderLeft = (x == x1 && (y >= y1 && y <= y2));
            bool isOnBorderRight = (x == x2 && (y >= y1 && y <= y2));
            bool isOnBorderUp = (y == y1 && (x >= x1 && x <= x2));
            bool isOnBorderDown = (y == y2 && (x >= x1 && x <= x2));
            if (isOnBorderLeft || isOnBorderRight || isOnBorderUp || isOnBorderDown)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
