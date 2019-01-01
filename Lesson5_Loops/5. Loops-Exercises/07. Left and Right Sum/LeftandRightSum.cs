using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class LeftandRightSum
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numCount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                leftSum += currentNum;
            }
            for (int i = 0; i < numCount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                rightSum += currentNum;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
