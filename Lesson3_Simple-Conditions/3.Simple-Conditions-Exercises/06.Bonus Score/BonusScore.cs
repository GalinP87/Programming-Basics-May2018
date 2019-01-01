using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus_Score
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            double points = double.Parse(Console.ReadLine());
            double bonus = 0;
            if (points <= 100)
            {
                bonus = 5;
            }
            else if (points > 1000)
            {
                bonus = points * 0.1;
            }
            else
            {
                bonus = points * 0.2;
            }
            if (points % 2 == 0)
            {
                bonus++;
            }
            if (points % 10 == 5)
            {
                bonus += 2;
            }
            double result = points + bonus;
            Console.WriteLine(bonus);
            Console.WriteLine(result);
        }
    }
}
