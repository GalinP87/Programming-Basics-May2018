using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.0;

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.5;
                }
                else if (product == "water")
                {
                    price = quantity * 0.8;
                }
                else if (product == "beer")
                {
                    price = quantity * 1.2;
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.45;
                }
                else
                {
                    price = quantity * 1.6;
                }
            }
            else if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.4;
                }
                else if (product == "water")
                {
                    price = quantity * 0.7;
                }
                else if (product == "beer")
                {
                    price = quantity * 1.15;
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.3;
                }
                else
                {
                    price = quantity * 1.5;
                }
            }
            else
            {
                if (product == "coffee")
                {
                    price = quantity * 0.45;
                }
                else if (product == "water")
                {
                    price = quantity * 0.7;
                }
                else if (product == "beer")
                {
                    price = quantity * 1.1;
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.35;
                }
                else
                {
                    price = quantity * 1.55;
                }
            }
            Console.WriteLine(price);
        }
    }
}
