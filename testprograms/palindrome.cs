using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprograms
{
    public class palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int temp = n;
            while(n>0)
            {
                int rem = n % 10; 
                rev = (rev * 10) + rem; 
                n = n / 10;
                
            }
            if(temp==rev)
            {
                Console.WriteLine("palindrome number: ");
            }
            else
            {
                Console.WriteLine("not palindrome: ");
            }
           

        }
    }
}
