using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03.Stop_Number___doWhile
{
    class StopNumberDo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            int num = m;

            do
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
            } while (num >= n);
        }
    }
}
