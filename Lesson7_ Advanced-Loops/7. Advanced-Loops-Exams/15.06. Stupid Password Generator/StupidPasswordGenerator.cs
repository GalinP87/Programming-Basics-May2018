using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._06.Stupid_Password_Generator
{
    class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int firstSymbol = 1; firstSymbol < n; firstSymbol++)
            {
                for (int secSymb = 1; secSymb < n; secSymb++)
                {
                    for (char thirdSymb = 'a'; thirdSymb < 'a' + l; thirdSymb++)
                    {
                        for (char fourSymb = 'a'; fourSymb < 'a' + l; fourSymb++)
                        {
                            for (int fifthSymb = 1; fifthSymb <= n; fifthSymb++)
                            {
                                if (fifthSymb > firstSymbol && fifthSymb > secSymb)
                                {
                                    Console.Write(firstSymbol);
                                    Console.Write(secSymb);
                                    Console.Write(thirdSymb);
                                    Console.Write(fourSymb);
                                    Console.Write(fifthSymb + " ");
                                }
                            }
                        }  
                    }
                }
            }
        }
    }
}
