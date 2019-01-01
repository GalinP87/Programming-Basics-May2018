using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Code_Name
{
    class CodeName
    {
        static void Main(string[] args)
        {
            char firstSym = char.Parse(Console.ReadLine());
            int sum = 0;
            int maxSum = int.MinValue;
            string output = string.Empty;

            for (char b = (char)100; b <= 111; b++)
            {
                for (char c = 'm'; c <= 'p'; c++)
                {
                    for (char d = 'J'; d <= 'O'; d++)
                    {
                        for (int e = 10; e <= 50; e += 2)
                        {
                            sum = firstSym + b + c + d + e;
                            if (sum % 10 == 8 && sum > maxSum)
                            {
                                maxSum = sum;
                                output = $"{firstSym}{b}{c}{d}{e}";
                            }
                        }
                    }
                }
            }
            Console.WriteLine(maxSum);
            Console.WriteLine(output);

        }
    }
}
