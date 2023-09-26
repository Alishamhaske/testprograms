using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    public class decendingarray
    {
        
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 3, 4, 5, 2, 4 };
            int temp;
             for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if (arr[i] < arr[j])
                    {
                      temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
             for(int i=0;i<arr.Length;i++)
             {
                Console.WriteLine(arr[i]);
             }
            Console.ReadLine();
            
        }

    }
}
