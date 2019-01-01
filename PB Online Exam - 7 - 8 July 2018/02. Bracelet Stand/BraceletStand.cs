using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bracelet_Stand
{
    class BraceletStand
    {
        static void Main(string[] args)
        {
            decimal pocketMoney = decimal.Parse(Console.ReadLine()) * 5;
            decimal revenue = decimal.Parse(Console.ReadLine()) * 5;
            decimal costs = decimal.Parse(Console.ReadLine());
            decimal giftPrice = decimal.Parse(Console.ReadLine());

            decimal totalMoney = pocketMoney + revenue - costs;

            if (totalMoney >= giftPrice)
            {
                Console.WriteLine($"Profit: {totalMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                decimal neededMoney = giftPrice - totalMoney;
                Console.WriteLine($"Insufficient money: {neededMoney:f2} BGN.");
            }
        }
    }
}
