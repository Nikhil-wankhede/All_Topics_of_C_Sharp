using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.OOPS
{

    interface IInterface
    {
        void Interface();
    }

    //We can not implement abstract class in interface
    //interface IInterface1 : AbstractClassExample
    //{

    //}

    internal abstract class AbstractClassExample : IInterface
    {
        public abstract void Test();
        public abstract void Test1();
        public abstract void Test2();
        public abstract void Test3();


        public virtual void Test5()
        {
            Console.WriteLine("base class Test 5");
        }

        public void Addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Interface()
        {
            throw new NotImplementedException();
        }
    }

    class UseOfAbstractClass : AbstractClassExample
    {
        public override void Test5()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------- Abstract Class ----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("An Abstract class is an incomplete class or special class we cannot instantiate. We can use an Abstract class as a Base Class. An Abstract method must be implement in the non-abstract class using the override keyword. \r\n1.\tAn abstract class can inherit from a class and one or more interfaces.\r\n2.\tAn abstract class can implement code with non-abstract methods.\r\n3.\tAn Abstract class can have modifiers for methods, properties etc.\r\n4.\tAn Abstract class can have constants and fields.\r\n5.\tAn abstract class can implement a property.\r\n6.\tAn abstract class can have constructors or destructors.\r\n7.\tAn abstract class cannot be inherit from the structures.\r\n8.\tAn abstract class cannot support multiple inheritance.\r\n\r\n\tAn abstract class is declared with the help of abstract keyword.\r\n\tIn C#, you are not allowed to create objects of the abstract class. Or in other words, you cannot use the abstract class directly with the new operator.\r\n\tClass that contains the abstract keyword with some of its methods(not all abstract method) is known as an Abstract Base Class.\r\n\tClass that contains the abstract keyword with all of its methods is known as pure Abstract Base Class.\r\n\tYou are not allowed to declare the abstract methods outside the abstract class.\r\n\tYou are not allowed to declare abstract class as Sealed Class.\r\n");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.White;


            Console.WriteLine("child class Test 5");
        }
        public override void Test()
        {

        }

        public override void Test1()
        {

        }

        public override void Test2()
        {

        }

        public override void Test3()
        {

        }
    }

}
