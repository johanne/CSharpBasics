using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars.DataPassing
{
    class ReferenceType
    {
        public class SimpleClass
        {
            public int i = 0;
        }

        public void DoSomethingByRefType(ref SimpleClass i)
        {
            i = new SimpleClass();
            Console.WriteLine("The value of i inisde reference type is {0}", i.i);
        }

        public void DoSomethingByValueType(SimpleClass i)
        {
            i = new SimpleClass();
            Console.WriteLine("The value of i inside is {0}", i);
        }


        public void Caller()
        {
            SimpleClass i = new SimpleClass();
            i.i = 10;
            Console.WriteLine("Calling Pass-by-value: i is initially {0}", i.i);
            DoSomethingByValueType(i);
            Console.WriteLine("After the method, i is now {0}", i.i);

            // Output should be:
            // 10
            // 0
            // 10

            Console.WriteLine("Calling Pass-by-reference: i is initially {0}", i.i);
            DoSomethingByRefType(ref i);
            Console.WriteLine("After the method, i is now {0}", i.i);

            // Output should be:
            // 10
            // 0
            // 0
        }

    }
}
