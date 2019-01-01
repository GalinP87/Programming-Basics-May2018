using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int pieces = width * height;

            while (pieces >= 0)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{pieces} pieces are left.");
                    break;
                }
                else
                {
                    int piece = int.Parse(input);
                    pieces -= piece;
                }
            }
            if (pieces <= 0)
            {
                Console.WriteLine($"No more cake left! You need {pieces * -1} pieces more.");
            }          
        }
    }
}
