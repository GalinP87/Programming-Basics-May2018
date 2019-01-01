using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Dance_Hall
{
    class DanceHall
    {
        static void Main(string[] args)
        {
            double hallLength = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());
            double hallArea = (hallLength * 100) * (hallWidth * 100);
            double wardrobeArea = (wardrobeSide * 100) * (wardrobeSide * 100);
            double benchArea = hallArea / 10.0;
            double freeArea = hallArea - wardrobeArea - benchArea;
            double dancers = freeArea / (40 + 7000);
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
