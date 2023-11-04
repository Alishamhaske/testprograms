using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.test24array
{
    internal class sumalternate
    {
        static void Main(string[] args)
        {
            //display sum alternate element
            int[] arr1 = new int[10];
            int sum = 0;
          
            Console.WriteLine("enter a numbers");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            

            for (int i = 0; i < arr1.Length-2; i++)
            {
                Console.WriteLine(arr1[i] + arr1[i+2]);
            }
           




            Console.ReadLine();
        }
    }
}
