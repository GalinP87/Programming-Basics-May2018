using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Transport_Price
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price = 0.0;

            if (km < 20)
            {
                if (time == "day")
                {
                    price = 0.7 + km * 0.79;
                }
                else
                {
                    price = 0.7 + km * 0.9;
                }
            }
            else if (km < 100)
            {
                price = km * 0.09;
            }
            else
            {
                price = km * 0.06;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
