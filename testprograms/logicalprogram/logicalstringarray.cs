using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.logicalprogram
{
    public class logicalstringarray
    {
        static void Main(string[] args)
        {
            /* 1.An array contains strings of different lengths. 
                 e.g. { ‘I’ , ‘am’ , ‘very’ , ‘smart’ }
             .Write a program such that array will contain all strings of same length,  
               output – { ‘Iam’ , ‘ver’ , ‘ysm’ , ‘art’ }*/

            string[] str = new string[] {"I","am","very","smart" };
            char[] ch;
            string str1 = " ";
          
            for(int i=0;i<str.Length;i++)
            {
               ch = str[i].ToCharArray();
               
                Console.Write(str[i]);
              
            }
        

            for (int i = 0; i < str.Length; i++)
            {
               
            }

            Console.ReadLine();



        }
    }
}
