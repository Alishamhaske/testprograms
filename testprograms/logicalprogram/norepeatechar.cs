using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.logicalprogram
{
    public class norepeatechar
    {
        static void Main(string[] args)
        {
            //3.Find first non-repeating letter in the  given string. 
            //e.g.Input string is ‘My Name is Yasmin’. First non-repeating string is ‘e’. 
          
            string str1= "My Name is Yasmin";
            string str2 = str1.ToLower();
            char[] ch = str2.ToCharArray();
       
            
            for (int i=0;i<ch.Length;i++)
            {
                int cnt = 1;
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        cnt++;
                    }
                }

                    if (cnt == 1)
                    {
                        Console.WriteLine(ch[i]);
                    break;
                    }
                
            }

        }
    }
}
