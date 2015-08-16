using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars.Structs
{
    // The default calue of this struct is set to all the default
    // values of the types contained in this struct
    // For all reference types, they are initialized to null
    struct MyStruct
    {
        string Name;
        private int test;

        // Will not compile
        // 1. Structs do not support protected, even in their fields
        // 2. Cannot initialize fields in a struct declaration
        // protected List<string> myList;// = new List<string>();
        // Constructor of structs must completely set
        // all the fields properly
        MyStruct(string structName)
        {
            Name = structName;
            this.test = 1;
        }

    }
}
