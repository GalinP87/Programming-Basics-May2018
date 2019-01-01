using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ExamOnTime
{
    class ExamOnTime
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arriveTime = arriveHour * 60 + arriveMinute;
            int diff = examTime - arriveTime;
            int diffHours = diff / 60;
            int diffMinutes = diff % 60;

            if (diff > 30)
            {
                Console.WriteLine("Early");
                if (diffHours == 0)
                {
                    Console.WriteLine($"{diffMinutes} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{diffHours}:{diffMinutes:d2} hours before the start");
                }
            }
            else if (30 >= diff && diff >= 0)
            {
                Console.WriteLine("On Time");
                if (diff != 0)
                {
                    Console.WriteLine($"{diffMinutes} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");
                diffHours *= -1;
                diffMinutes *= -1;
                if (diffHours == 0)
                {
                    Console.WriteLine($"{diffMinutes} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{diffHours}:{diffMinutes:d2} hours after the start");
                }
            }
        }
    }
}
