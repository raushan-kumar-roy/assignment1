using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    public static class factor
    {
        public static void CheckPrimeFactor()
        {
            int a, b;
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());

            for (b = 2; a > 1; b++)

                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine($"{b} is prime factor {x} Times");
                }

        }
    }
}
