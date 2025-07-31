using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.OOPS
{

    class DestructorsExample
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public DestructorsExample()
        {

        }
        ~DestructorsExample()
        {
            //Garbage Collector called 
            GC.Collect();
        }
    }

    internal class CalledGarbaseCollector
    {
        public void Call_GC()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------- Destructor --------------------------");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Destructors in C# are methods inside the class used to destroy instances of that class when they are no longer needed. The Destructor is called implicitly by the .NET Framework’s Garbage collector and therefore programmer has no control as when to invoke the destructor. An instance variable or an object is eligible for destruction when it is no longer reachable.\r\n\tA Destructor is unique to its class i.e. there cannot be more than one destructor in a class.\r\n\tA Destructor has no return type and has exactly the same name as the class name.\r\n\tIt is distinguished apart from a constructor because of the Tilde symbol (~) prefixed to its name. \r\n\tA Destructor does not accept any parameters and modifiers. \r\n\tIt cannot be defined in Structures. It is only used with classes. \r\n\tIt cannot be overloaded or inherited. \r\n\tIt is called when the program exits.\r\n\tInternally, Destructor called the Finalize method on the base class of object.\r\n\r\nclass DestructorsExample\r\n    {\r\n        public string Name { get; set; }\r\n        public int ID { get; set; }\r\n        public DestructorsExample()\r\n        {\r\n\r\n        }\r\n        ~ DestructorsExample()\r\n        {\r\n         //Garbage Collector called \r\n            GC.Collect();        \r\n  }\r\n    }\r\n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            DestructorsExample obj = new DestructorsExample();
            obj.ID = 10;
            obj.Name = "Manoj";
        }
    }
}
