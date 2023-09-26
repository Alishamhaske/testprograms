using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static testprograms.mock.exliplictinterface;

namespace testprograms.mock
{
    public class interface2
    {
        static void Main(string[] args)
        {
            Icustomer i1 = new transcation();
            Iorder i2 = new transcation();
            i1.display();
            i2.display();

        }
    }

   /* When two different interfaces have same method declaration
        & a single class implements both interface ,
   we need  to implements interfaces explicitly 
  ( interface name.method)
    */

    public class exliplictinterface
    {
        public interface Icustomer
        {
            void display();
        }
        public interface Iorder
        {
            void display();
        }

        public class transcation:Icustomer,Iorder
        {
            void Icustomer.display()
            {
           
                Console.WriteLine("Customer details first  icustomer interface method ");
            }
            void Iorder.display()
            {
                Console.WriteLine("order details second  iorder interface method ");
            }
        }


    }
}
