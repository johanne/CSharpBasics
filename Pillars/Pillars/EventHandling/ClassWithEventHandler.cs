using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars.EventHandling
{
    class ClassWithEventHandler
    {
        // this is our listener list
        public MyDelegate List;

        // This is the method signature for the 
        // events that will occur
        public delegate void MyEventHandler(int s);

        // This is the handler for all the events
        // Note: you can remove the event keyword
        // but the event keyword keeps things working by
        // ensuring that the event handler does not get
        // instantiated with a new list
        public event MyEventHandler SomeEvent;

        // delegate is our eventhandler type
        public delegate void MyDelegate(int i);
        public static void DoSomething(int i) 
        {
            Console.WriteLine("I'm doing something");
        }

        public static void DoAnotherThing(int i) 
        {
            Console.WriteLine("I'm doing another thing");
        }
        public ClassWithEventHandler() 
        {
        }




    }
}
