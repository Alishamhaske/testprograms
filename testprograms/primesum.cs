using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    internal class primesum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=0;i<=20;i++)
            {
                int cnt = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                        break;
                    }
                }
                    if(cnt==0)
                    {
                        sum = sum + i;
                    }
               

            }
            Console.WriteLine(sum);

        }
    }
}
