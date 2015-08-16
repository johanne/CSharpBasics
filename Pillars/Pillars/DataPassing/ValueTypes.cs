using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars.DataPassing
{
    class ValueTypes
    {

        public void DoSomethingByRefType(ref int i)
        {
            i += 10;
            Console.WriteLine("The value of i inisde reference type is {0}", i);
        }

        public void DoSomethingByValueType(int i)
        {
            i += 10;
            Console.WriteLine("The value of i inside is {0}", i);
        }


        public void Caller()
        {
            int i = 1;
            Console.WriteLine("Calling Pass-by-value: i is initially {0}", i);
            DoSomethingByValueType(i);
            Console.WriteLine("After the method, i is now {0}", i);

            // Output should be:
            // 1
            // 11
            // 1

            Console.WriteLine("Calling Pass-by-reference: i is initially {0}", i);
            DoSomethingByRefType(ref i);
            Console.WriteLine("After the method, i is now {0}", i);

            // Output should be:
            // 1
            // 11
            // 11
        }
    }
}
