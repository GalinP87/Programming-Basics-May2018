using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03.Stop_Number___while
{
    class StopNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            int num = m;

            while (num >= n)
            {
                if (num % 6 == 0)
                {
                    if (num != s)
                    {
                        Console.Write(num + " ");
                    }
                    else
                    {
                        break;
                    }
                }
                num--;
            }
        }
    }
}
