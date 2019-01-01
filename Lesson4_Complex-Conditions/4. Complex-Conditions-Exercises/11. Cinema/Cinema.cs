using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double price = 0.0;
            double result = 0.0;

            if (projection == "premiere")
            {
                price = 12.00;
            }
            else if (projection == "normal")
            {
                price = 7.50;
            }
            else
            {
                price = 5;
            }
            result = rows * columns * price;
            Console.WriteLine($"{result:f2} leva");
        }
    }
}
