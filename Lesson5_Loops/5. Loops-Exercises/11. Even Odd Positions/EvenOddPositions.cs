using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Even_Odd_Positions
{
    class EvenOddPositions
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0.0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0.0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    oddSum += currentNum;
                    if (currentNum < oddMin)
                    {
                        oddMin = currentNum;
                    }
                    if (currentNum > oddMax)
                    {
                        oddMax = currentNum;
                    }
                }
                else
                {
                    evenSum += currentNum;
                    if (currentNum < evenMin)
                    {
                        evenMin = currentNum;
                    }
                    if (currentNum > evenMax)
                    {
                        evenMax = currentNum;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum}");
            if (n == 0)
            {
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine($"EvenSum={evenSum}");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("ËvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin}");
                Console.WriteLine($"OddMax={oddMax}");
                Console.WriteLine($"EvenSum={evenSum}");
                if (n == 1)
                {
                    Console.WriteLine("EvenMin=No");
                    Console.WriteLine("ËvenMax=No");
                }
                else
                {
                    Console.WriteLine($"EvenMin={evenMin}");
                    Console.WriteLine($"ËvenMax={evenMax}");
                }
            }
        }
    }
}
