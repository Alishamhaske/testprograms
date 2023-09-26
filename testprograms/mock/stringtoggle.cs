using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.mock
{
    public class stringtoggle
    {
        static void Main(string[] args)
        {
            //toggle 
            Console.WriteLine("enter a string: ");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();

            for(int i=0;i<ch.Length;i++)
            {
                if (ch[i]>='A' && ch[i]<='Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                    Console.WriteLine(ch[i]);
                }
            
                else if (ch[i]>='a' && ch[i]<='z')
                {
                    ch[i] = (char)(ch[i] - 32);
                    Console.WriteLine(ch[i]);
                }
            }

                    
        }
    }
}
