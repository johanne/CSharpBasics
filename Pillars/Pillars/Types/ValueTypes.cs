using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars.Types
{
    class ValueTypes
    {
        int a;
        char b;



        // As well as all other primitive types

        // The constructors of value types, in the example below
        // c is also initialized to the default value of 
        // the integer type. In this case, it would be equivalent
        // to 0.
        int c = new int();
        int d = 0;

        // Additionally, this can be considered as a value type:
        struct MySpecialCase
        {
            string myString;

        }
    }
}
