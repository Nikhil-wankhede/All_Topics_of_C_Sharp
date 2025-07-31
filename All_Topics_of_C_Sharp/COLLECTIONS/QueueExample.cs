using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace All_Topics_of_C_Sharp.COLLECTIONS
{
    class QueueExample
    {
        public void InitializeQueueExample()
        {
            Queue objQueue = new Queue();
            Queue<string> genericQueue = new Queue<string>();
            genericQueue.Enqueue("Nikhil");
            genericQueue.Enqueue("Wankhede");
            genericQueue.Enqueue("Dot Net");
            genericQueue.Enqueue("Developer");

            Console.WriteLine("Printing Queue");
            foreach (var element in genericQueue)
            {
                Console.WriteLine(element);
            }

            var removedElement = genericQueue.Dequeue();
            Console.WriteLine("Removed Element is : " + removedElement);
            Console.WriteLine("Printing Queue after removing element");
            foreach (var element in genericQueue)
            {
                Console.WriteLine(element);
            }

        }
    }
}
