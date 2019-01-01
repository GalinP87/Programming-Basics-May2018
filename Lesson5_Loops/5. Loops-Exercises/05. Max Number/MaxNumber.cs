using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;

            for (int i = 0; i < numCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxValue)
                {
                    maxValue = currentNumber;
                }
            }
            Console.WriteLine(maxValue);
        }
    }
}
