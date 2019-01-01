using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._02.Magic_Combination
{
    class MagicCombination
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int d1 = 1;
            while (d1 <= 9)
            {
                int d2 = 1;
                while (d2 <= 9)
                {
                    int d3 = 1;
                    while (d3 <= 9)
                    {
                        int d4 = 1;
                        while (d4 <= 9)
                        {
                            int d5 = 1;
                            while (d5 <= 9)
                            {
                                int d6 = 1;
                                while (d6 <= 9)
                                {
                                    if (d1 * d2 * d3 * d4 * d5 * d6 == n)
                                    {
                                        Console.Write($"{d1}{d2}{d3}{d4}{d5}{d6} ");
                                    }
                                    d6++;
                                }
                                d5++;
                            }
                            d4++;
                        }
                        d3++;
                    }
                    d2++;
                }
                d1++;
            }

        }
    }
}
