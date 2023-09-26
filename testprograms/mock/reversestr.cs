using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.mock
{
    public class reversestr
    {
        static void Main(string[] args)
        {

            string str = "hello";
            char[] ch = str.ToCharArray();
            string str1 = " ";
            for(int i=0;i<ch.Length;i++)
            {
                str1 = ch[i] + str1;
              
            }
            Console.WriteLine(str1);
            /*for(int i=str.Length-1;i >=0;i--)
            {
                Console.Write(ch[i] );
            }*/
            Console.WriteLine();
        }
    }
}
