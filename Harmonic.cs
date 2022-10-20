using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    public static class Harmonic
    {
        public static void CheckHarmonic()
        {
            int count, num;
            double sum = 0;

            Console.WriteLine("n/n");
            Console.WriteLine(" Harmonic series: /n");
            Console.WriteLine(" \n\n");
            Console.WriteLine(" Enter the value of N ");
            num = Convert.ToInt32(Console.ReadLine());

            for (count = 1; count <= num; count++) ;
            {
                Console.WriteLine(" 1/{0} + ", count);
            }
            Console.WriteLine("\n {0}: {1} \n", num, sum);


        }
    
}
}
