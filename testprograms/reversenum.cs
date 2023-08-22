using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    public class reversenum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            while(n>0)
            {
                int rem = n % 10; 
                rev = (rev * 10) + rem; 
                n = n / 10;
                
            }
            Console.WriteLine("reverse num:"+rev);

        }
    }
}
