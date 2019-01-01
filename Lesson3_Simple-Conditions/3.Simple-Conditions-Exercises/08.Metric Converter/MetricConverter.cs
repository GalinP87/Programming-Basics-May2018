using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_Converter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();
            double numInMeters = num;
            if (inputMetric == "mm")
            {
                numInMeters /= 1000; 
            }
            else if (inputMetric == "cm")
            {
                numInMeters /= 100;
            }
            else if (inputMetric == "mi")
            {
                numInMeters /= 0.000621371192;
            }
            else if (inputMetric == "in")
            {
                numInMeters /= 39.3700787;
            }
            else if (inputMetric == "km")
            {
                numInMeters /= 0.001;
            }
            else if (inputMetric == "ft")
            {
                numInMeters /= 3.2808399;
            }
            else if (inputMetric == "yd")
            {
                numInMeters /= 1.0936133;
            }
            double outputNum = numInMeters;
            if (outputMetric == "mm")
            {
                outputNum *= 1000;
            }
            else if (outputMetric == "cm")
            {
                outputNum *= 100;
            }
            else if (outputMetric == "mi")
            {
                outputNum *= 0.000621371192;
            }
            else if (outputMetric == "in")
            {
                outputNum *= 39.3700787;
            }
            else if (outputMetric == "km")
            {
                outputNum *= 0.001;
            }
            else if (outputMetric == "ft")
            {
                outputNum *= 3.2808399;
            }
            else if (outputMetric == "yd")
            {
                outputNum *= 1.0936133;
            }
            Console.WriteLine($"{outputNum:f8}");
        }
    }
}
