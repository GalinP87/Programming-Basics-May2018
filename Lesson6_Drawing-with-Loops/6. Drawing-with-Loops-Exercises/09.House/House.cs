using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = 1;
            if (n % 2 == 0)
            {
                stars++;
            }

            for (int rows = 0; rows < (n + 1) / 2; rows++)
            {
                int dashes = (n - stars) / 2;
                Console.Write(new string('-', dashes));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', dashes));
                stars += 2;
            }

            for (int rows = 0; rows < n / 2; rows++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', n - 2));
                Console.WriteLine(new string('|', 1));
            }
        }
    }
}
