using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Alcohol_Market
{
    class AlcoholMarket
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double rakiaPrice = whiskeyPrice * 0.5;
            double winePrice = rakiaPrice * 0.6;
            double beerPrice = rakiaPrice * 0.2;
            double beerLtr = double.Parse(Console.ReadLine());
            double wineLtr = double.Parse(Console.ReadLine());
            double rakiraLtr = double.Parse(Console.ReadLine());
            double whiskeyLtr = double.Parse(Console.ReadLine());
            double rakiaSum = rakiaPrice * rakiraLtr;
            double wineSum = winePrice * wineLtr;
            double beerSum = beerPrice * beerLtr;
            double whiskeySum = whiskeyPrice * whiskeyLtr;
            double totalSum = rakiaSum + wineSum + beerSum + whiskeySum;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
