using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Birthday
{
    class Birthday
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentTaken = double.Parse(Console.ReadLine());
            int VolumeInCm = length * width * height;
            double VolumeInLiters = VolumeInCm / 1000.0;
            double LitersToFill = VolumeInLiters * (1 - (percentTaken / 100));
            Console.WriteLine($"{LitersToFill:F3}");
        }
    }
}
