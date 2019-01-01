using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeA = int.Parse(Console.ReadLine());
            int sizeB = int.Parse(Console.ReadLine());
            int Area = sizeA * sizeB;
            Console.WriteLine(Area);
        }
    }
}
