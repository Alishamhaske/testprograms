using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.logicalprogram
{
    public class nthmin
    {
        /// 1.	Write a  program to find nth lowest number in an array/arraylist.
        /// N is less than (length of array – 1)

        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int n, temp;
            Console.WriteLine("enter a elements:");
            for(int i=0;i<arr1.Length;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

           
            for (int i=0;i<arr1.Length;i++)
            {
                for(int j=i+1;j<arr1.Length;j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                    

                }
            }
            Console.WriteLine("array elemnts");
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("enter nth smallest number: ");
            n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < arr1.Length; i++)
            {
                if (i == n)
                {
                    Console.WriteLine(arr1[i - 1]);
                }
            }

            Console.ReadLine();

        }
    }
}
