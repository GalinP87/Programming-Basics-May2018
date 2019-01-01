using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            double inputSum = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();
            double usdToBGN = 1.79549;
            double eurToBGN = 1.95583;
            double gbpToBGN = 2.53405;
            double outputSum = 1.0;

            switch (inputCurrency)
            {
                case "USD":
                    outputSum = inputSum * usdToBGN;
                    break;
                case "EUR":
                    outputSum = inputSum * eurToBGN;
                    break;
                case "GBP":
                    outputSum = inputSum * gbpToBGN;
                    break;
                default:
                    outputSum = inputSum;
                    break;
            }
            switch (outputCurrency)
            {
                case "USD":
                    outputSum = outputSum / usdToBGN;
                    break;
                case "EUR":
                    outputSum = outputSum / eurToBGN;
                    break;
                case "GBP":
                    outputSum = outputSum / gbpToBGN;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{outputSum:f2} {outputCurrency}");
        }
    }
}
