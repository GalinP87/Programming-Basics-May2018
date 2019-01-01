using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int diffMax = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int sumOld = sum;
                int currentNum1 = int.Parse(Console.ReadLine());
                int currentNum2 = int.Parse(Console.ReadLine());
                sum = currentNum1 + currentNum2;
                if (i != 0)
                {
                    int diff = Math.Abs(sum - sumOld);
                    if (diff > diffMax)
                    {
                        diffMax = diff;
                    }
                }
            }
            if (diffMax == 0 || diffMax == int.MinValue)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diffMax}");
            }
        }
    }
}
