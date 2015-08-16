using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars.Types
{
    // Value types cannot be derived,
    // but structs can implement interfaces
    struct StructValueType : Interfaces.ISimpleInterface
    {
        // In this example, this 
        public void DoSomething() { }
    }

    /*
    // Cannot inherit from a struct
    struct SomeInheritingStruct : StructValueType
    {
        override void DoSomething() { }
    }
    */
}
