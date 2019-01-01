using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Training_Lab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine()) * 100;
            double width = double.Parse(Console.ReadLine()) * 100;

            int columns = (int)((width - 100) / 70);
            int rows = (int)(length / 120);
            int seats = columns * rows - 3;
            Console.WriteLine(seats);
        }
    }
}
