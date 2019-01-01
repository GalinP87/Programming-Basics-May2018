using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SushiTime
{
    class SushiTime
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int countPortions = int.Parse(Console.ReadLine());
            char delivery = char.Parse(Console.ReadLine());
            double price = 0.0;

            if (restaurant == "Sushi Zone")
            {
                if (sushi == "sashimi")
                {
                    price = 4.99;
                }
                else if (sushi == "maki")
                {
                    price = 5.29;
                }
                else if (sushi == "uramaki")
                {
                    price = 5.99;
                }
                else
                {
                    price = 4.29;
                }
            }
            else if (restaurant == "Sushi Time")
            {
                if (sushi == "sashimi")
                {
                    price = 5.49;
                }
                else if (sushi == "maki")
                {
                    price = 4.69;
                }
                else if (sushi == "uramaki")
                {
                    price = 4.49;
                }
                else
                {
                    price = 5.19;
                }
            }
            else if (restaurant == "Sushi Bar")
            {
                if (sushi == "sashimi")
                {
                    price = 5.25;
                }
                else if (sushi == "maki")
                {
                    price = 5.55;
                }
                else if (sushi == "uramaki")
                {
                    price = 6.25;
                }
                else
                {
                    price = 4.75;
                }
            }
            else if (restaurant == "Asian Pub")
            {
                if (sushi == "sashimi")
                {
                    price = 4.50;
                }
                else if (sushi == "maki")
                {
                    price = 4.80;
                }
                else if (sushi == "uramaki")
                {
                    price = 5.50;
                }
                else
                {
                    price = 5.50;
                }
            }
            price *= countPortions;
            if (delivery == 'Y')
            {
                price *= 1.2;
            }
            if (price == 0)
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
            }
            else
            {
                Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
            }
        }
    }
}
