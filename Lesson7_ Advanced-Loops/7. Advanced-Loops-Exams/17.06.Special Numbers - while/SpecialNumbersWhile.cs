using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._06.Special_Numbers___while
{
    class SpecialNumbersWhile
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d1 = 1;
            int d2 = 1;
            int d3 = 1;
            int d4 = 1;

            while (d1 < 10)
            {
                if (n % d1 == 0)
                {
                    while (d2 < 10)
                    {
                        if (n % d2 == 0)
                        {
                            while (d3 < 10)
                            {
                                if (n % d3 == 0)
                                {
                                    while (d4 < 10)
                                    {
                                        if (n % d4 == 0)
                                        {
                                            Console.Write($"{d1}{d2}{d3}{d4} ");
                                        }
                                        d4++;
                                    }
                                }
                                d3++;
                            }
                        }
                        d2++;
                    }
                }
                d1++;
            }
        }
    }
}
