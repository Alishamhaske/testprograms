using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testprograms
{
    public class prime11_21
    {
        static void Main(string[] args)
        {
            
            
            for(int n=11;n<=31;n++)
            {
                
                int count = 0;

                for (int i=2;i<n;i++)
                {
                    if(n%i==0)
                    {
                        count++;
                        break;
                    }

                }
                if (count==0)
                {
                    Console.WriteLine($"prime number:{n}");
                }

            }
        }
    }
}
