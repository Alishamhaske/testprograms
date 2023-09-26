using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    public class sumdigit
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter a string:");
            //string str = Console.ReadLine();
            string str = "sfdfsfd3242";
            int sum = 0;
            char[] ch = str.ToCharArray();
           

            for (int i=0;i<ch.Length;i++)
            {
                if ((ch[i] >= 'A' && ch[i] <= 'Z') || (ch[i] >= 'a' && ch[i] <= 'z'))
                {
                    continue;
                }
                else if (ch[i] >= '0' && ch[i] <= '9')
                {
                    sum = sum + ch[i];
                }



            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
