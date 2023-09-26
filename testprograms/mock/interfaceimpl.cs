using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static testprograms.mock.implictinterface;

namespace testprograms.mock
{
    public class interfaceimpl
    {
        static void Main(string[] args)
        {

            mastani m1 = new mastani();
            m1.eat();
            m1.drink();

           

        }
    }
    //implict interface implementation
    public class implictinterface
    {
        interface icecream
        {
            void eat();
        }
        interface juice
        {
            void drink();
        }

        public class mastani :icecream,juice
        {
         

            public void eat()
            {
                Console.WriteLine("Ice-Cream Interface implemented");
            }
            public void drink()
            {
                Console.WriteLine("Juice Interface implemented");
            }
        }

    }
}
