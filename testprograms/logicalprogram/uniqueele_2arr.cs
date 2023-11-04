using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.logicalprogram
{
    public class uniqueele_2arr
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("enter elements is 1st array:");
        */
          
            Console.WriteLine("enter a array elemnets:");
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            for(int i=0;i<arr1.Length;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter a second array elemnts:");
            for(int i=0;i<arr2.Length;i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            //
            for(int i=0;i<arr1.Length;i++)
            {
                int cnt = 1;
                for(int j=0;j<arr2.Length;j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        cnt++;
                      
                    }
                   
                }
                if(cnt==1)
                {
                    Console.WriteLine("unique elements: "+arr1[i]);
                }
                
            }

            Console.ReadLine();

        }
    }
}
