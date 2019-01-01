using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int minNum = num;

            for (int i = 0; i < numCount - 1; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num < minNum)
                {
                    minNum = num;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
