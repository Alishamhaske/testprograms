using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.mock
{
    public class fibo
    {
        //find fibonacci series in given array
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
        
            int temp;
            for(int i=0;i<n;i++)
            {
                int c = a+b;
                Console.WriteLine(c);
                temp = a;
                a= b;
                b=c;

            }
        }
    }
}
