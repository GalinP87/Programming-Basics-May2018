using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int f0 = 0;
            int f1 = 1;          

            for (int fibb = 0; fibb < n; fibb++)
                {
                    int output = 1;
                    output = f0 + f1;
                    f0 = f1;
                    f1 = output;
                }
            Console.WriteLine(f1);
        }
    }
}
