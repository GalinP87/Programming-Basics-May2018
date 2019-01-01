using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Charity
{
    class Charity
    {
        static void Main(string[] args)
        {
            int charityDays = int.Parse(Console.ReadLine());
            int cookers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            int cakesSumDaily = cakes * 45;
            double wafflesSumDaily = waffles * 5.8;
            double pancakesSumDaily = pancakes * 3.2;

            double totalSum = (cakesSumDaily + wafflesSumDaily + pancakesSumDaily) * cookers * charityDays;
            totalSum -= totalSum / 8.0;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
