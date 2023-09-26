using System;

namespace testprograms.logicalprogram
{
    public class uniquechar_2str
    {
        /* 2.	There are 2 string . Find  program to find character 
         in first string which is not in second string.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 st string:");
            string str1 = Console.ReadLine();
            char[] ch1 = str1.ToCharArray();

            Console.WriteLine("Enter 2nd string:");
            string str2 = Console.ReadLine();
            char[] ch2 = str2.ToCharArray();

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (ch1[i] == ch2[j])
                    {
                        ch1[i] = ' ';

                    }
                }
                Console.WriteLine(ch1[i]);
            }
            Console.ReadLine();
            // string str = new string(ch1); //Ch convert to string
        }
    }
}
