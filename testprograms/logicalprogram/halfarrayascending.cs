using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.logicalprogram
{
    public class halfarrayascending
    {
        static void Main(string[] args)
        {
            //accpect array and sort half array in decending and next half is asending
            int[] arr1 = new int[7];
         
            int temp ;
            Console.WriteLine("enter array elements:");
            for(int i=0;i<arr1.Length;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length/2; i++)
            {
                for (int j = i + 1; j < arr1.Length/2; j++)
                {
                    if (arr1[i] > arr1[j])        //ascending
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            //
         
            ////
            for (int i = arr1.Length/2; i < arr1.Length ; i++)
            {
                for (int j = i + 1; j < arr1.Length ; j++)
                {
                    if (arr1[i] < arr1[j])        //decending
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }


            Console.WriteLine("first half part is ascending and next half is  decending sort");
            for (int i = 0; i < arr1.Length ; i++)
            {
                Console.WriteLine(arr1[i]);
            }


        }
    }
}
