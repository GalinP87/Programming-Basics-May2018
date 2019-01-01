using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Tailoring_Workshop
{
    class TailoringWorkshop
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());
            double coverLength = tableLength + 2 * 0.30;
            double coverWidth = tableWidth + 2 * 0.30;
            double squareCoverSide = tableLength / 2;
            double totalCoverArea = tables * coverLength * coverWidth;
            double totalSqCoverArea = tables * squareCoverSide * squareCoverSide;
            double priceUSD = totalCoverArea * 7 + totalSqCoverArea * 9;
            double priceBGN = priceUSD * 1.85;
            Console.WriteLine($"{priceUSD:f2} USD");
            Console.WriteLine($"{priceBGN:f2} BGN");

        }
    }
}
