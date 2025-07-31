using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.OOPS
{
    internal class PrivateConstructorExample
    {
        public static int ID { get; set; }
        public static string Name { get; set; }

        private PrivateConstructorExample()
        {

        }

        public PrivateConstructorExample(string name)
        {

        }
    }
    class CallPrivateCtor
    {
        public void RunPrivateCtor()
        {
            Console.Clear();
            Console.WriteLine("**************************** Constructor ****************************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Private Constructor :- ");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("When a constructor is created with a private specifier, it is not possible for other classes to derive from this class, neither is it possible to create an instance of this class. They are usually used in classes that contain static members only. \r\nSome key points of a private constructor are:\r\n\tOne use of a private constructor is when we have only static members.\r\n\tIt provides an implementation of a singleton class pattern\r\n\tOnce we provide a constructor that is either private or public or any, the compiler will not add the parameter-less public constructor to the class.\r\n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            //PrivateConstructorExample obj = new PrivateConstructorExample();

            PrivateConstructorExample obj = new PrivateConstructorExample("Name");
        }

    }
}
