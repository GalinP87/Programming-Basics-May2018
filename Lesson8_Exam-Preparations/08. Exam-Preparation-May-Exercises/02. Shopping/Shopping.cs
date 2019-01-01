using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Shopping
{
    class Shopping
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double choco = double.Parse(Console.ReadLine());
            double milk = double.Parse(Console.ReadLine());
            double tangerines = (int)(choco - choco * 0.35);

            choco *= 0.65;
            milk *= 2.7;
            tangerines *= 0.2;

            double totalSum = choco + milk + tangerines;

            if (budget >= totalSum)
            {
                Console.WriteLine($"You got this, {(budget - totalSum):f2} money left!");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalSum - budget):f2} more!");
            }
        }
    }
}
