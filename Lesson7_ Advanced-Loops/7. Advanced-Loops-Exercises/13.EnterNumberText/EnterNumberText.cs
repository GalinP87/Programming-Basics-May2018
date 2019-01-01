using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.EnterNumberText
{
    class EnterNumberText
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter even number:");
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {n}");
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
                catch (Exception)
                {

                    Console.WriteLine("Ïnvalid number."); ;
                }
            }
        }
    }
}
