using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    public static class evenOdd
    {
        public static void checkEvenOdd()
        {
            int number, remainder;
            Console.WriteLine("Enter any number");
            number = Convert.ToInt32(Console.ReadLine());

            remainder = number % 2;
            if (remainder == 0)
            {
                Console.WriteLine("{0}is an  even Number", number);
            }
            else
            {
                Console.WriteLine("{0}is an odd Number", number);
            }

        }
    }
}
