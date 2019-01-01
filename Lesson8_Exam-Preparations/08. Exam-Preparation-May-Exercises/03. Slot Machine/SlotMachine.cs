using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Slot_Machine
{
    class SlotMachine
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            int firstNum = int.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int first = firstSymbol + firstNum;
            int second = secondSymbol + secondNum;
            int third = thirdSymbol + thirdNum;
            Console.WriteLine($"{(char)first}{(char)second}{(char)third}");

            if (first == '7' && second == '7' && third == '7')
            {
                Console.WriteLine("*** JACKPOT ***");
            }
            else if (first == '@' && second == '@' && third == '@')
            {
                Console.WriteLine("!!! YOU LOSE EVERYTHING !!!");
            }


        }
    }
}
