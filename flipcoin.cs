using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    public static class flipcoin
    {
        public static void CheckPercentage()
        {
            int headcount = 0;
            int tailcount = 0;
            double headpercentage = 0;
            double tailpercentage = 0;

            Console.WriteLine("please enter the value for number of flip");
            int numberofFlip = Convert.ToInt32(Console.ReadLine());

            if (numberofFlip > 0)
            {
                for (int i = 0; i < numberofFlip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine(number);
                    if (number == 0)
                    {
                        tailcount++;
                    }
                    else
                    {
                        headcount++;
                    }

                }
                headpercentage = headcount * 100 / numberofFlip;
                tailpercentage = tailcount * 100 / numberofFlip;

                Console.WriteLine("headpercentage" + tailpercentage);
                Console.WriteLine("tailpercentage" + headpercentage);
            }
        }
    }
}
