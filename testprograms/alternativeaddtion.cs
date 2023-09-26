using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    internal class alternativeaddtion
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 4, 10, 2, 7, 6, 5 };
          
            for (int i = 0; i < arr1.Length-2; i++)
            {

                Console.WriteLine(arr1[i] + arr1[i+2]);

            }
          
        }
 
    }
}
