using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*',size));
            for (int i = 0; i < size - 2; i++)
            {
                Console.WriteLine('*' + new string(' ',size - 2) + '*');
            }
            Console.WriteLine(new string('*', size));
        }
    }
}
