using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
            }
            if (maxNum == (sum - maxNum))
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - 2 * maxNum)}");
            }
        }
    }
}
