using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    public class evenavg
    {
        static void Main(string[] args)
        {
            //find avg of even digit
            int digit, sum=0,count=0, avg=0;
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());           //12345
            while(n!=0)
            {
              
                digit = n % 10;            //5
                n = n / 10;               //1234
                if(digit%2==0)
                {
                    count++;
                    sum =sum+ digit;
                    avg = sum / count;
                }
            }
            Console.WriteLine(avg);
        }
    }
}
