using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace All_Topics_of_C_Sharp.COLLECTIONS
{
    class StackExample
    {
        public void InitializeStackExample()
        {
            #region Non-generic Stack Object

            Stack objStack = new Stack();
            objStack.Push("Nikhil");
            objStack.Push("Wankhede");
            objStack.Push("Dot Net");
            objStack.Push("Developer");
            objStack.Push(400);
                        
            #endregion


            #region Generic Stack Object

            Stack<int> genericStack = new Stack<int>();
            genericStack.Push(10);
            genericStack.Push(20);
            genericStack.Push(30);
            genericStack.Push(40);

            #endregion
            Console.WriteLine("Printing Stack ");

            foreach (var element in genericStack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Next Removable element in Stack is : " + genericStack.Peek());
            genericStack.Pop();

            foreach (var element in genericStack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Next Removable element in Stack is : " + genericStack.Peek());

        }
    }
}
