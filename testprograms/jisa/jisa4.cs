using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.jisa
{
    public class jisa4
    {
        static void Main(string[] args)
        {

            //specialReverseString("Edabit") ➞ "Tibade"

            string str = "Edabit";
            str=str.ToLower();
            char[] ch = str.ToCharArray();

            for(int i =ch.Length-1;i>=0;i--)

            {
                if (ch[i] ==ch[ch.Length-1] )
                {
                    char ch1 = (char)(ch[i] - 32);
                    Console.Write(ch1);
                }
                else
                {
                    Console.Write(ch[i]);
                }
               



            }


            Console.ReadLine();
        }
    }
}
