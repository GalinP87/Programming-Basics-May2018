using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._06.Special_Numbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int d1 = 1; d1 < 10; d1++)
            {
                if (n % d1 == 0)
                {
                    for (int d2 = 1; d2 < 10; d2++)
                    {
                        if (n % d2 == 0)
                        {
                            for (int d3 = 1; d3 < 10; d3++)
                            {
                                if (n % d3 == 0)
                                {
                                    for (int d4 = 1; d4 < 10; d4++)
                                    {
                                        if (n % d4 == 0)
                                        {
                                            Console.Write($"{d1}{d2}{d3}{d4} ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
