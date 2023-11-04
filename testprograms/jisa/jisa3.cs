using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace testprograms.jisa
{
    public class jisa3
    {
        static void Main(string[] args)
        {
            /*
               Create a function that takes in a sentence as input
               and returns true if there is at least one alphabetically
               sorted word inside that has a minimum length of 3.*/

            string str1 = "word  abc inside that   ";
            str1.ToLower();
            int cnt = 0;
           
            string[] str2 = str1.Split();

            for (int i = 0; i < str2.Length; i++)
            {
                int n = str2[i].Length;
                if (n >= 3)
                {
                    char[] ch = str2[i].ToCharArray();
                    Array.Sort(ch);
                    string str = new string(ch);
                    if (str2[i] == str)
                    {
                        cnt++;
                    }

                }
            }   
            if(cnt>0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }





            Console.ReadLine();

        }

    }
}
