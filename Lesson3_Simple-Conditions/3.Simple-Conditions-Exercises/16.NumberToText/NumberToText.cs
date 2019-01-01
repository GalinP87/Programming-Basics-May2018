using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumberToText
{
    class NumberToText
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tens = num / 10;
            int digits = num % 10;
            string outputDigits = null;
            string outputTens = null;

            if (num == 0)
            {
                Console.WriteLine("zero");
            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (num == 10)
            {
                Console.WriteLine("ten");
            }
            else if (num == 11)
            {
                Console.WriteLine("eleven");
            }
            else if (num == 12)
            {
                Console.WriteLine("twelve");
            }
            else if (num == 13)
            {
                Console.WriteLine("thirteen");
            }
            else if (num == 14)
            {
                Console.WriteLine("fourteen");
            }
            else if (num == 15)
            {
                Console.WriteLine("fifteen");
            }
            else if (num == 16)
            {
                Console.WriteLine("sixteen");
            }
            else if (num == 17)
            {
                Console.WriteLine("seventeen");
            }
            else if (num == 18)
            {
                Console.WriteLine("eightteen");
            }
            else if (num == 19)
            {
                Console.WriteLine("nineteen");
            }
            else if (num < 0 || num > 100)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                switch (tens)
                {
                    case 2:
                        outputTens = "twenty"; break;
                    case 3:
                        outputTens = "thirty"; break;
                    case 4:
                        outputTens = "forty"; break;
                    case 5:
                        outputTens = "fifty"; break;
                    case 6:
                        outputTens = "sixty"; break;
                    case 7:
                        outputTens = "seventy"; break;
                    case 8:
                        outputTens = "eighty"; break;
                    case 9:
                        outputTens = "ninety"; break;
                    default:
                        break;
                }
                switch (digits)
                {
                    case 1:
                        outputDigits = "one"; break;
                    case 2:
                        outputDigits = "two"; break;
                    case 3:
                        outputDigits = "three"; break;
                    case 4:
                        outputDigits = "four"; break;
                    case 5:
                        outputDigits = "five"; break;
                    case 6:
                        outputDigits = "six"; break;
                    case 7:
                        outputDigits = "seven"; break;
                    case 8:
                        outputDigits = "eight"; break;
                    case 9:
                        outputDigits = "nine"; break;
                    default:
                        break;
                }
                if (tens == 0)
                {
                    Console.WriteLine(outputDigits);
                }
                else if (digits == 0)
                {
                    Console.WriteLine(outputTens);
                }
                else
                {
                    Console.WriteLine($"{outputTens} {outputDigits}");
                }
            }       
        }
    }
}
