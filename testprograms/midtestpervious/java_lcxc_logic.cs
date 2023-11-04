using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.midtestpervious
{
    internal class java_lcxc_logic
    {
        static void Main(string[] args)
        {
            //java=lcxc
            //zbyc=bdae
       

            Console.WriteLine("enter a string");
            string str2 = Console.ReadLine();
            str2 = str2.ToLower();
            char[] ch2 = str2.ToCharArray();
            //java=lcxc
            //zbyc=bdae

            for (int i = 0; i < ch2.Length; i++)
            {
                if (ch2[i]=='z' || ch2[i]=='y')
                {
                    //ch2[i] = (char)(ch2[i] - 56);
                    ch2[i] = (char)(ch2[i] - 24);
                    Console.Write(ch2[i]);
                }
                else
                { 
                    ch2[i] = (char)(ch2[i] + 2);
                    Console.Write(ch2[i]);
                }
                
            }

           
            Console.ReadLine();

        }
    }
}
