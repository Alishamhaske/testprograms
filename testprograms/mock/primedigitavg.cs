using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.mock
{
    public class primedigitavg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int digit;
            int sum = 0;
            int avg = 0;
            int cnt2 = 0;
            while (n!=0)
            {
                digit = n % 10;
                n = n / 10;

                    int cnt = 1;
                   
                    for (int j=2;j<digit;j++)
                    {
                        if(digit%j==0)
                        {
                            cnt++;
                        }
                    }
             
                    if(cnt==1)
                    {
                        cnt2++;
                        sum = sum + digit;
                      
                    }
                avg = sum / cnt2;
                
             
            }
            Console.WriteLine("sum of prime digit :" +sum);
            Console.WriteLine("avg of prime digit in number:" +avg);



        }
    }
}
