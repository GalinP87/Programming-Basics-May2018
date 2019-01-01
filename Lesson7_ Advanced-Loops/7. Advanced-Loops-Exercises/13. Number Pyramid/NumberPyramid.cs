using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 0;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write($"{++currentNum} ");
                    if (currentNum == n)
                    {
                        break;
                    }
                }
                if (currentNum == n)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
