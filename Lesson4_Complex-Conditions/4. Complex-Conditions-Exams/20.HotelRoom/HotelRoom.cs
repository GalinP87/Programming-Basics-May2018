using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double aptBookingPrice = 0.0;
            double studioBookingPrice = 0.0;

            if (month == "May" || month == "October")
            {
                aptBookingPrice = nights * 65;
                studioBookingPrice = nights * 50;
                if (nights > 14)
                {
                    aptBookingPrice *= (1 - 0.1);
                    studioBookingPrice *= (1 - 0.3);
                }
                else if (nights > 7)
                {
                    studioBookingPrice *= (1 - 0.05);
                }
            }
            else if (month == "June" || month == "September")
            {
                aptBookingPrice = nights * 68.7;
                studioBookingPrice = nights * 75.2;
                if (nights > 14)
                {
                    aptBookingPrice *= (1 - 0.1);
                    studioBookingPrice *= (1 - 0.2);
                }
            }
            else
            {
                aptBookingPrice = nights * 77;
                studioBookingPrice = nights * 76;
                if (nights > 14)
                {
                    aptBookingPrice *= (1 - 0.1);
                }
            }
            Console.WriteLine($"Apartment: {aptBookingPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioBookingPrice:f2} lv.");
        }
    }
}
