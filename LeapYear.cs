using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    public static class LeapYear
    {
        public static void CheckYear()
        {
            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100! == 0 || (year % 400 == 0)))
            {
                Console.WriteLine(year + "is leaf year");


            }
            else
            {
                Console.WriteLine(year + "is not leaf year");
            }
        }
    }
}
