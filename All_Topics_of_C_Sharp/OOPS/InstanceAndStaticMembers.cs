using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.OOPS
{
    internal class InstanceAndStaticMembers
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static int PinCode { get; set; }
        public static int I { get; set; } = 20;
        public int P { get; set; } = 30;


        /// <summary>
        /// This will return the addition of two provided numbers
        /// </summary>
        /// <param name="a">First Number for Addition</param>
        /// <param name="b">Second Number for Addition</param>
        /// <returns>Returns the addition of 2 numbers</returns>
        public static int Addition(int a, int b)
        {
            Console.WriteLine(PinCode);
            return a + b;
        }

        /// <summary>
        /// This method will Print the value from Name Property
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine(PinCode);
            Console.WriteLine(Name);
        }
    }
    class UseOfClassMembers
    {
        public void AccessMembers()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------- Instance and Static Members ---------------------------------");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Static Members :-");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("The members of the class that can be access without creating an instance & directly by using the class name are called as static members");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Instance Members :-");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The members of the class that can not be access without creating an instance for the class are called as instance members");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Static Field :-");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("When the field is declared as static only, one copy of static variable is created and it is shared by different instances of the class\r\nStatic members/ fields can be access directly by using class name\r\nSyntax- <access modifier> static <return type> variable;\r\n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Static Method :-");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Static methods are used to access other static members(fields). These methods are accessed directly using class name");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("“this” keyword :-");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("“this” is the keyword which is used as a reference to the current variable or object.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            InstanceAndStaticMembers obj3;
            obj3 = new InstanceAndStaticMembers();
            //Instance Members can be accessed by Class object
            InstanceAndStaticMembers obj = new InstanceAndStaticMembers();
            obj.Name = "Manoj";
            obj.ID = 100;
            obj.PrintName();
            obj.P = 300;
            Console.WriteLine(obj.P);

            InstanceAndStaticMembers obj2 = new InstanceAndStaticMembers();
            obj2.P = 500;
            Console.WriteLine(obj2.P);
            Console.WriteLine(obj.P);
            Console.WriteLine(InstanceAndStaticMembers.I);


            InstanceAndStaticMembers.I = 3000;
            //Static members can be accessed directly by using Class name
            InstanceAndStaticMembers.PinCode = 100;

            int result = InstanceAndStaticMembers.Addition(10, 20);
            InstanceAndStaticMembers.Addition(10, 60);

        }
    }
}
