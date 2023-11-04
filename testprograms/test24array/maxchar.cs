using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.test24array
{
    internal class maxchar
    {
        static void Main(string[] args)
        {
           //2. find the max char from array
            char[] c = new char[5];
            char max = c[0];
           Console.WriteLine("enter a character:");
            for (int i=0;i<c.Length;i++)
            {
                c[i] = Convert.ToChar(Console.ReadLine());  
            }
            for(int i=0;i<c.Length;i++)
            {
                if (c[i]>max)
                {
                    max = c[i];
                }
            }
            Console.WriteLine("max char is "+max);
            Console.ReadLine();
        }
    }
}
