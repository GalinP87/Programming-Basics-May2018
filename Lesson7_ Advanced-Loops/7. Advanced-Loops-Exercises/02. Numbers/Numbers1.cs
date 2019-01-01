using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers
{
    class Numbers1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = n; num > 0; num--)
            {
                Console.WriteLine(num);
            }
        }
    }
}
