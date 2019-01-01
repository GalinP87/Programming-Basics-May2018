using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Draw_Fort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string top = "/" + new string('^', n / 2) +"\\";
            if (n <= 4)
            {
                Console.WriteLine(top + top);
            }
            else
            {
                Console.WriteLine(top + new string('_', 2 * n - 4 - 2 * (n / 2)) + top);
            }

            for (int row = 0; row < n - 3; row++)
            {
                if (n == 4)
                {
                    Console.WriteLine('|' + new string(' ', n / 2 + 1) + new string(' ', n / 2 + 1) + '|');
                }
                else
                {
                    Console.WriteLine('|' + new string(' ', n / 2 + 1) + new string(' ', 2 * n - 4 - 2 * (n / 2)) + new string(' ', n / 2 + 1) + '|');
                }
                
            }

            string bottom = "\\" + new string('_', n / 2) + "/";
            if (n <= 4)
            {
                Console.WriteLine('|' + new string(' ', 2 * n - 2) + '|');
                Console.WriteLine(bottom + bottom);
            }
            else
            {
                Console.WriteLine('|' + new string(' ', n / 2 + 1) + new string('_', 2 * n - 4 - 2 * (n / 2)) + new string(' ', n / 2 + 1) + '|');
                Console.WriteLine(bottom + new string(' ', 2 * n - 4 - 2 * (n / 2)) + bottom);
            }

        }
    }
}
