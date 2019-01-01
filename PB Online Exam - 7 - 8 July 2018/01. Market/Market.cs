using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Market
{
    class Market
    {
        static void Main(string[] args)
        {
            double kgTomatoes = double.Parse(Console.ReadLine()) * 0.9;
            double kgCherrys = double.Parse(Console.ReadLine()) * 0.9;
            int countLettuce = int.Parse(Console.ReadLine()) - 1;
            double kgCashew = double.Parse(Console.ReadLine());

            double tomatoesCost = kgTomatoes * 2.79;
            double cherrysCost = kgCherrys * 30;
            double lettuceCost = countLettuce * 1.20;
            double cashewCost = kgCashew * (2.20 * 10);

            double revenue = tomatoesCost + cherrysCost + lettuceCost + cashewCost;
            Console.WriteLine($"Final sum is: {revenue:f2} lv.");
        }
    }
}
