using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int output = 1;

            for (int num = 0; num <= n; num++)
            {
                Console.WriteLine(output);
                output *= 2;
            }
        }
    }
}
