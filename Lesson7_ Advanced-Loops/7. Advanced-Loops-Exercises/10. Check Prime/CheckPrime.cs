using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int num = 2; num <= Math.Sqrt(n); num++)
            {
                if (n % num == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime && n > 1)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
