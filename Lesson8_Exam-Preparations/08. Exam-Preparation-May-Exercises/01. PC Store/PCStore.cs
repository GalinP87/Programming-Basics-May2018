using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PC_Store
{
    class PCStore
    {
        static void Main(string[] args)
        {
            double priceCPU = double.Parse(Console.ReadLine());
            double priceGPU = double.Parse(Console.ReadLine());
            double priceRAM = double.Parse(Console.ReadLine());
            int countRAM = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            priceCPU *= 1.57;
            priceGPU *= 1.57;
            priceRAM *= 1.57;
            priceRAM *= countRAM;
            priceCPU *= (1 - discount);
            priceGPU *= (1 - discount);
            double totalPrice = priceCPU + priceGPU + priceRAM;
            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");

        }
    }
}
