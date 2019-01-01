using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Night_Lamp
{
    class NightLamp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n + 7;
            int width = 4 * n + 11;

            int leftRight = n + 4;
            int middle = 0;

            Console.WriteLine(new string('.', leftRight) + new string('_', n) + @"/|\" + new string('_', n) + new string('.', leftRight));

            for (int row = 0; row < n + 5; row++)
            {
                middle = width - 2 * leftRight - 2;
                Console.Write(new string('.', leftRight) + '/');
                if (row == 0)
                {
                    Console.Write(new string('-', middle));
                }
                else if (row == 4 || row > n + 2)
                {
                    Console.Write(new string('_', middle));
                }
                else
                {
                    Console.Write(new string('.', middle));
                }
                Console.WriteLine('\\' + new string('.', leftRight));
                leftRight--;
            }
            leftRight = 2 * n + 4;
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('.', leftRight) + "|$|" + new string('.', leftRight));
            }
            Console.WriteLine(new string('.', 4) + new string('_', 2 * n) + "|$|" + new string('_', 2 * n) + new string('.', 4));
            Console.WriteLine(new string('.', 3) + '/' + new string('_', 4 * n + 3) + '\\' + new string('.', 3));
        }
    }
}
