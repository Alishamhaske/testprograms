using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    internal class sumofeven
    {
        static void Main(string[] args)
        {
            //sumof even number in array
            int[] arr1 = new int[10];
            int sum = 0, avg = 0;
            int cnt = 0;

            Console.WriteLine("enter a numbers");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr1.Length; i++)
            {
              
                if (arr1[i]%2==0)
                {
                    cnt++;
                    sum = sum + arr1[i];
                }
            }
            Console.WriteLine(sum);
            avg = sum / cnt; 
            Console.WriteLine("avg is:"+avg);

        }
    }
}
