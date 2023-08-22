using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    public class tqwelcome
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i+ "  welocme to TQ");
                }
                else if(i%5==0)
                {
                    Console.WriteLine(i+"  Welcome");
                }
                else if(i%3==0)
                {
                    Console.WriteLine(i+"  TQ");
                }
                
                

            }
            
        }
    }
}
