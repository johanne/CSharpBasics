using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[][] input = new int[10][10];

            Stack<int> myStack = new Stack<int>();
            int[][] visitArray = new int[10][10];
            // visit first node
            myStack.Push(1);
            visitArray[1][1] = 1;

            // while stack is not empty, there might still be unvisited nodes
            while (myStack.Count > 0)
            {
                int currentNode = myStack.Pop();
                for (int i = 0; i < 10; i++)
                {
                    if (input[currentNode][i] == 1 && visitArray[currentNode][i] == 0)
                    {
                        myStack.Push(input[currentNode][i]);
                        visitArray[currentNode][i] = 1;
                        currentNode = input[currentNode][i];
                        break;
                    }
                }
                
            }
            */

        }
        private string First;
        private string Last;
        public void DoSomething() => Console.WriteLine("I'm doing something");
        public string Name => First + "" + Last;
    }
}
