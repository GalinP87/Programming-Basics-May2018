using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Truck_Driver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            int totalCurses = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            int coursesToFrance = 0;
            int coursesToBelgium = 0;
            int coursesToSweden = 0;
            int totalKM = 0;

            for (int cours = 1; cours <= totalCurses; cours++)
            {
                string destination = Console.ReadLine();

                if (destination == "France")
                {
                    coursesToFrance++;
                    totalKM += 1884;
                }
                else if (destination == "Belgium")
                {
                    coursesToBelgium++;
                    totalKM += 1815;
                }
                else
                {
                    coursesToSweden++;
                    totalKM += 1991;
                }

                if (cours % 2 == 0)
                {
                    salary *= 1.20;
                }
            }
            salary *= totalKM;
            Console.WriteLine($"Courses to France: {coursesToFrance}");
            Console.WriteLine($"Courses to Belgium: {coursesToBelgium}");
            Console.WriteLine($"Courses to Sweden: {coursesToSweden}");
            Console.WriteLine($"Total: {totalKM} km");
            Console.WriteLine($"Salary: {salary:f2} lv.");
        }
    }
}
