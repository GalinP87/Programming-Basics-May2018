using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"Even number entered: {n}");
                    break;
                }
                Console.WriteLine("The number is not even.");
                n = int.Parse(Console.ReadLine());  
            }

        }
    }
}
