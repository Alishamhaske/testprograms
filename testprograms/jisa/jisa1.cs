using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.jisa
{
    public class jisa1
    {
        static void Main(string[] args)
        {
            // alphbabetically sorted consecutive  aplhabetical order 
            // accent , ghost
            // means a before c , c before e , e before n, n before t 

/*

            string str = "accent";
            str.ToLower();
            char[] ch = str.ToCharArray();
*/

           /////
           ///

            Console.WriteLine("enter s string");
            string str1 = Console.ReadLine();
            str1.ToLower();
            char[] ch = str1.ToCharArray();
            

            bool isconsecutive = true;
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] > ch[j])
                    {
                        isconsecutive = false;
                        break;
                    }
                }

            }
            if (isconsecutive == true)
            {
                Console.WriteLine("Consective string: " + str1);
            }
            else
            {
                Console.WriteLine("not consecutive");
            }

            Console.ReadLine();


        }
    }
}
