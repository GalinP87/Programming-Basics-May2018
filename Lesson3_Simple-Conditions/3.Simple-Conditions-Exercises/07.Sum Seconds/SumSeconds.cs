using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Seconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());
            int totalTime = time1 + time2 + time3;
            int mins = totalTime / 60;
            int secs = totalTime % 60;
            Console.WriteLine($"{mins}:{secs:d2}");
        }
    }
}
