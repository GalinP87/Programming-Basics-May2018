using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n + 5;

            int leftRight = (width - 1) / 2;

            Console.Write(new string('_', leftRight));
            Console.Write('^');
            Console.WriteLine(new string('_', leftRight));
            leftRight--;

            Console.Write(new string('_', leftRight));
            Console.Write("/|\\");
            Console.WriteLine(new string('_', leftRight));
            leftRight--;

            for (int row = 0; row < n / 2; row++)
            {
                Console.Write(new string('_', leftRight - row));
                Console.Write("/" + new string('.', row));
                Console.Write("|||");
                Console.Write(new string('.', row) + '\\');
                Console.WriteLine(new string('_', leftRight - row));
            }

            leftRight -= 2;
            Console.Write(new string('_', leftRight));
            Console.Write("/..|||..\\");
            Console.WriteLine(new string('_', leftRight));
            leftRight++;

            Console.Write(new string('_', leftRight));
            Console.Write("/.|||.\\");
            Console.WriteLine(new string('_', leftRight));
            leftRight += 2;

            for (int row = 0; row <= n; row++)
            {
                Console.Write(new string('_', leftRight));

                if (row == n)
                {
                    Console.Write("~~~");
                }
                else
                {
                    Console.Write("|||");
                }                
                Console.WriteLine(new string('_', leftRight));
            }
            leftRight--;

            for (int row = 0; row < n / 2; row++)
            {
                Console.Write(new string('_', leftRight - row));
                Console.Write("//" + new string('.', row));
                Console.Write("!");
                Console.Write(new string('.', row) + "\\\\");
                Console.WriteLine(new string('_', leftRight - row));
            }

        }
    }
}
