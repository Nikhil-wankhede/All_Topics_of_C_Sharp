using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.OOPS
{
    internal class MethodoverridingExample
    {
        public void InitializeMethodOverridingExample()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------- Polymorphism --------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************** Run Time Polymorphism **************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Method Overriding Example :- ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Method overriding- override a base class method in the derived class by creating a method with the same name and same signatures to perform a different task. The Method Overriding in c# can be achieved by using override & virtual keywords along with the inheritance principle. The base class method which we want to override in the derived class that needs to be defined with virtual keyword and we need to use override keyword in derived class while defining the method with the same name and parameters then only we can override the base class method in a derived class.");
            Console.WriteLine();


            ChildMethodOverriding obj = new ChildMethodOverriding();
            CaluculateTotal(10, 20);

        }
        public virtual int CaluculateTotal(int a, int b)
        {
            return a + b;
        }
    }
    class ChildMethodOverriding : MethodoverridingExample
    {
        public override int CaluculateTotal(int a, int b)
        {
            return a * b;
        }

        public void Test()
        {
            CaluculateTotal(10, 20);
        }

    }
}
