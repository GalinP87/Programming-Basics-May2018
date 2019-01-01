using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int pow = 0; pow <= n; pow+=2)
            {
                Console.WriteLine(Math.Pow(2, pow));
            }
        }
    }
}
