using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapePerSqM = double.Parse(Console.ReadLine());
            double wineDemand = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double totalGrape = area * grapePerSqM;
            double totalWine = (totalGrape * 0.4) / 2.5;
            double diff = totalWine - wineDemand;

            if (diff < 0)
            {
                diff *= -1;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(diff)} liters left -> {Math.Ceiling(diff/workers)} liters per person.");
            }
        }
    }
}
