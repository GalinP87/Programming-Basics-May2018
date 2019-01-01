using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Smart_Lilly
{
    class SmartLilly
    {
        static void Main(string[] args)
        {
            int ageLilly = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int savedMoney = 0;         

            for (int i = 1; i <= ageLilly; i++)
            {
                if (i % 2 == 1)
                {
                    savedMoney += toyPrice;
                }
                else
                {
                    savedMoney += i / 2 * 10;
                    --savedMoney;
                }
            }
            double diff = Math.Abs(savedMoney - laundryPrice);
            if (savedMoney >= laundryPrice)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }        
    }
}
