using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.test24array
{
    internal class vowel
    {
        static void Main(string[] args)
        {
            //9.	Write a C# program to count total number of vowels and consonants in a string.

            string str1 = "good night";

            char[] strobj = str1.ToCharArray();
            int cnt1 = 0;
            int cnt2 = 0;
            for (int i = 0; i < strobj.Length; i++)
            {
                if (strobj[i] == 'a' || strobj[i] == 'e' || strobj[i] == 'i' || strobj[i] == 'o' || strobj[i] == 'u')
                {
                    cnt1++;
                    Console.WriteLine("vowel is "+strobj[i]);

                }
                else 
                {
                    cnt2++;
                    Console.WriteLine(strobj[i]);

                }


            }
            Console.WriteLine("number of vowel is: " + cnt1);
            Console.WriteLine("number of constant is: " + cnt2);

        }
    }
}
