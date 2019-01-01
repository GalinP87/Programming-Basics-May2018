using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000_Days_After_Birth
{
    class DaysAfterBirth
    {
        static void Main(string[] args)
        {
            string birthDate = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime date = DateTime.ParseExact(birthDate , format , null);
            DateTime newDate = date.AddDays(999);
            Console.WriteLine(newDate.ToString(format));
        }
    }
}
