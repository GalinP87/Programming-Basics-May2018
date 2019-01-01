using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());
           
            int count = 0;

            for (char first = startLetter; first <= endLetter; first++)
            {
                for (char second = startLetter; second <= endLetter; second++)
                {
                    for (char third = startLetter; third <= endLetter; third++)
                    {
                        if (first != skipLetter && second != skipLetter && third != skipLetter)
                        {
                            Console.Write($"{first}{second}{third} ");
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
