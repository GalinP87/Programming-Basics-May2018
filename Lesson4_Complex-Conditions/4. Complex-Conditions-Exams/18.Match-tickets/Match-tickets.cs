using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Match_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            double fans = double.Parse(Console.ReadLine());

            double ticketMoney = 0.0;

            if (1 <= fans && fans <= 4)
            {
                ticketMoney = budget * (1 - 0.75);
            }
            else if (5 <= fans && fans <= 9)
            {
                ticketMoney = budget * (1 - 0.6);
            }
            else if (10 <= fans && fans <= 24)
            {
                ticketMoney = budget * (1 - 0.5);
            }
            else if (25 <= fans && fans <= 49)
            {
                ticketMoney = budget * (1 - 0.4);
            }
            else
            {
                ticketMoney = budget * (1 - 0.25);
            }

            double neededMoney = fans * 499.99;
            if (category != "VIP")
            {
                neededMoney = fans * 249.99;
            }

            if (ticketMoney >= neededMoney)
            {
                Console.WriteLine($"Yes! You have {(ticketMoney - neededMoney):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(neededMoney - ticketMoney):f2} leva.");
            }
        }
    }
}
