using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    public class evenfact_square
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                int digit = n % 10;
                n = n / 10;

                if(digit%2==0)
                {
                    for(int i=1; i<=digit;i++)
                    {
                        if(digit%i==0)
                        {
                            Console.WriteLine($"factor of even {digit} number:  " +i);
                        }
                    }
                }
                else 
                {
                    Console.WriteLine($"square of  odd  { digit} number: " +(digit* digit));
                }

            }
        }
    }
}
