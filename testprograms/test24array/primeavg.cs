using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms.test24array
{
    public class primeavg
    {
        static void Main(string[] args)
        {
            //find the avg of prime number in array
            int[] arr = new int[5];
            int sum = 0, avg = 0, index = 0;
           
           
            for(int i=0;i<arr.Length;i++)
            {

                Console.WriteLine("enter a element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i++)
            {
                int cnt = 0;

                for (int j = 2; j < arr[i];j++)
                {
                    if (arr[i] %j==0)
                    {
                        cnt++;
                        break;
                    }
                    
                }
                if (cnt == 0)
                {
                    //Console.WriteLine("prime" + arr[i]);
                    sum = sum + arr[i];
                    index++;
                }
                
            }
            avg = sum / index;
            Console.WriteLine(sum);
            Console.WriteLine("avarage of prime number: "+avg);


        }
    }
}
