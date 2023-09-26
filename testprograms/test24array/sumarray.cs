using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.test24array
{
    public class sumarray
    {
        static void Main(string[] args)
        {
            //1.find sum of array element
            int[] arr1 = new int[6];
            int sum = 0;
            Console.WriteLine("eneter a numbers: ");
            for(int i=0;i<arr1.Length;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i=0;i<arr1.Length;i++)
            {
                sum = sum + arr1[i];
            }
            Console.WriteLine("sum of element in array;  " +sum);
        }
    }
}
