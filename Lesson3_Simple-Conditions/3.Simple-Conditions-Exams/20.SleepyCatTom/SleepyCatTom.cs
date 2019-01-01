using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.SleepyCatTom
{
    class SleepyCatTom
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int daysWork = 365 - daysOff;

            int playTime = daysOff * 127 + (365 - daysOff) * 63;
            int difference = playTime - 30000;
            int diffHours = difference / 60;
            int diffMinutes = difference % 60;

            if (difference > 0)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{diffHours} hours and {diffMinutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Abs(diffHours)} hours and {Math.Abs(diffMinutes)} minutes less for play");
            }
        }
    }
}
