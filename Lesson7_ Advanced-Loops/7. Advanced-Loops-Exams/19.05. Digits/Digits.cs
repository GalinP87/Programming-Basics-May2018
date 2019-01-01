using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._05.Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int d1 = num / 100;
            int d2 = (num % 100) / 10;
            int d3 = num % 10;

            for (int row = 0; row < d1 + d2; row++)
            {
                for (int col = 0; col < d1 + d3; col++)
                {
                    if (num % 5 == 0)
                    {
                        num -= d1;
                    }
                    else if (num % 3 == 0)
                    {
                        num -= d2;
                    }
                    else
                    {
                        num += d3;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
