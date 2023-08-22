using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    public class factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, cnt = 0, avg = 0;
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    cnt++;
                    sum = sum + i;

                    Console.WriteLine(i);
                }
                avg = sum / cnt;
                
            }
            Console.WriteLine("avg of factor:"+avg);
        }
    }
}
