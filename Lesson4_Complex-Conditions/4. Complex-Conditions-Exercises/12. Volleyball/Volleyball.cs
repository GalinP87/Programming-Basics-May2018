using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int weekendsInSofia = 48 - h;
            double satPlaySf = weekendsInSofia * 3 / 4.0;
            double holPlaySf = p * 2 / 3.0;
            double totalPlayDays = satPlaySf + h + holPlaySf;
            if (year == "leap")
            {
                totalPlayDays *= 1.15;
            }
            Console.WriteLine($"{Math.Floor(totalPlayDays)}");
        }
    }
}
