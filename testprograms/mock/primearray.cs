using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.mock
{
    public class primearray
    {
        //prime array
        static void Main(string[] args)
        {
            int[] arr1 = new int[6];
            Console.WriteLine("enter a array elements: ");
            for(int i=0;i<arr1.Length;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("prime elements");
            for (int i=0;i<arr1.Length;i++)
            {
                int cnt = 1;
                for(int j = 2; j < arr1[i];j++)
                {
                    if (arr1[i]%j==0)
                    {
                        cnt++;
                        break;
                    }
                }
                if(cnt==1)
                {
                    Console.WriteLine(arr1[i]);
                }
            }




        }
    }
}
