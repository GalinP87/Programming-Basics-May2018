using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;
            if (shape == "square")
            {
                double size = double.Parse(Console.ReadLine());
                area = size * size;
            }
            else if (shape == "rectangle")
            {
                double sizeA = double.Parse(Console.ReadLine());
                double sizeB = double.Parse(Console.ReadLine());
                area = sizeA * sizeB;
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (shape == "triangle")
            {
                double sizeA = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = sizeA * height / 2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
