using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._2D_Rectangle_Area
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double sizeA = Math.Abs(x1 - x2);
            double sizeB = Math.Abs(y1 - y2);
            double area = sizeA * sizeB;
            double Perimeter = 2 * (sizeA + sizeB);
            Console.WriteLine(area);
            Console.WriteLine(Perimeter);
        }
    }
}
