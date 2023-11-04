using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.mock
{
    public class india
    {
        //str1= india
        //str2 =  in   // is same 
        //only print da
        static void Main(string[] args)
        {
            string str1 = "India";
            string str2 = "in";
            string str3 = str1.ToLower();
            string str4 = str2.ToLower();
            char[] ch1 = str3.ToCharArray();
            char[] ch2 = str4.ToCharArray();

            for(int i=0;i<str3.Length;i++)
            {
                for(int j=0;j<str4.Length;j++)
                {
                    if (ch1[i] == ch2[j])
                    {
                        ch1[i] = ' ';
                    }
                }
            }
            Console.WriteLine(ch1);

            //string str = new string(ch1);
            Console.ReadLine();

        }
    }
}
