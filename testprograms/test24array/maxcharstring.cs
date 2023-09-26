using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.test24array
{
    internal class maxcharstring
    {
        static void Main(string[] args)
        {
            //find the max char from the string
            string s= "hello everyone";
            char[] c = s.ToCharArray();
            char max = c[0];
            for(int i = 0; i < c.Length;i++)
            {
                if (c[i]>max)
                {
                    max = c[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
