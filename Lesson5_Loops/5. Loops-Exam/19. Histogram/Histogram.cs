using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < 200)
                {
                    p1++;
                }
                else if (200 <= currentNum && currentNum < 400)
                {
                    p2++;
                }
                else if (400 <= currentNum && currentNum < 600)
                {
                    p3++;
                }
                else if (600 <= currentNum && currentNum < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            p1 = p1 / n * 100;
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            p4 = p4 / n * 100;
            p5 = p5 / n * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
