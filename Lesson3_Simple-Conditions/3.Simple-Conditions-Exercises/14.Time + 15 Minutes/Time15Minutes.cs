using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time___15_Minutes
{
    class Time15Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            mins = mins + 15;
            if (mins > 59)
            {
                hours = hours + 1;
                mins = mins - 60;
                if (hours > 23)
                {
                    hours = hours - 24;
                }
            }
            Console.WriteLine($"{hours}:{mins:d2}");
        }
    }
}
