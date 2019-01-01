using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Pool_Pipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            double volume = int.Parse(Console.ReadLine());
            int debitP1 = int.Parse(Console.ReadLine());
            int debitP2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double pipe1 = debitP1 * hours;
            double pipe2 = debitP2 * hours;
            double totalWater = pipe1 + pipe2;

            if (totalWater <= volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%", Math.Truncate(totalWater / volume * 100), Math.Truncate(pipe1 / totalWater * 100), Math.Truncate(pipe2 / totalWater * 100));
            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {(totalWater - volume):f1} liters");
            }
        }
    }
}
