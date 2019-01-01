using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Operations
{
    class Operations
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0.0;

            if (n2 == 0 && (operation == '/' || operation == '%'))
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (operation == '/')
            {
                result = n1 / n2;
                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
            else if (operation == '%')
            {
                result = n1 % n2;
                Console.WriteLine($"{n1} % {n2} = {result}");
            }
            else
            {
                string residue = "odd";
                switch (operation)
                {
                    case '+':
                        result = n1 + n2;
                        break;
                    case '-':
                        result = n1 - n2;
                        break;
                    default:
                        result = n1 * n2;
                        break;
                }
                if (result % 2 == 0)
                {
                    residue = "even";
                }
                Console.WriteLine($"{n1} {operation} {n2} = {result} - {residue}");
            }
        }
    }
}
