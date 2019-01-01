using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', 2 * n + 1));
            Console.WriteLine(new string('.', n + 1));
            for (int row = 0; row < n + 1; row++)
            {
                if (row == n)
                {
                    Console.Write("//" + new string('_', n + row - 3));
                    Console.Write("STOP!");
                    Console.WriteLine(new string('_', n + row - 3) + @"\\");
                }
                else
                {
                    Console.Write(new string('.', n - row));
                    Console.Write("//");
                    Console.Write(new string('_', 2 * (n + row)- 1));
                    Console.Write("\\\\");
                    Console.WriteLine(new string('.', n - row));
                }
            }
            for (int row = 0; row < n; row++)
            {
                Console.Write(new string('.', row));
                Console.Write("\\\\");
                Console.Write(new string('_', 2 * (2 * n - row) - 1));
                Console.Write("//");
                Console.WriteLine(new string('.', row));
            }
        }
    }
}
