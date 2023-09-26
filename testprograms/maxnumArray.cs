using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    public class maxnumArray
    {
        static void Main(string[] args)
        {
            //maximum number in array
            int[] arr2 = new int[5] { 3, 43, 2, 21, 1, };
            int max = arr2[0];
            for(int i=0;i<arr2.Length;i++)
            {
                if (arr2[i]>max)
                {
                    max = arr2[i];
                }
            }
            Console.WriteLine(max);

        }
    }
}
