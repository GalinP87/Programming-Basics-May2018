﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Excellent_Result
{
    class ExcellentResult
    {
        static void Main(string[] args)
        {
            double result = double.Parse(Console.ReadLine());
            if (result >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
