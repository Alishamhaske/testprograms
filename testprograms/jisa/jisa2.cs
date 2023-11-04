using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.jisa
{
    public class jisa2
    {

       
        static void Main(string[] args)

        {

            /* 832= 594
             reverse number  and original number minus reverse number if output is negative than print 0
            832-238=594

        51=36
        79977=180
        149=0
        149-941= - 92     negative result than print 0
             */

            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int temp = n;
            int no2 = 0;

            while (n != 0)
            {
                int digit = n % 10;
                rev = (rev * 10) + digit;
                n = n / 10;
            }
            no2 = temp - rev;
            if (no2 > 0)
            {
                Console.WriteLine(no2);
            }
            else
            {
                Console.WriteLine(0);
            }



            Console.ReadLine();
        }

    }
}
