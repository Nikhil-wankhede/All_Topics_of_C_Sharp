using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace All_Topics_of_C_Sharp.OOPS
{
        #region basic Inheritance with Constructor

        internal class Inheritance_Example
        {
            public void InitializeInheritanceExample()

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------------------- Object Oriented Programming ----------------------------");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("1.\tClass\r\n2.\tObject and Instance\r\n3.\tData Encapsulation\r\n4.\tData Abstraction / Data hiding\r\n5.\tInheritance\r\n6.\tPolymorphism\r\n");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("Class");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("A class is a way to bind the data member and member functions together. A class enables you to create your custom types by grouping variables of other types, methods, and events.");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("Object and Instance");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("When an object is created without using the keyword “new” then the memory will allocate in stack and object in stack contains a null value.\r\nWhen an object is created using the keyword “new” then memory will be allocated in Heap memory and its address will be store in stack, which is called as Instance.\r\n");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("Data Encapsulation");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("The process of wrapping of data into a single unit (class) is called as data encapsulation. In a different way, encapsulation is a protective shield that prevents the data from being accessed by the code outside this shield.");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("Data Abstrction");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The process of hiding the details of the class from rest of the program is called as data abstraction. It is used to hide the implementation details and display only essential features of the object. In C# abstraction is achieved with the help of Abstract classes, and access modifiers.");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("Inheritance");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The process of creating a new class from an existing class is called as inheritance\r\nThe main advantage of inheritance is re-usability, maintenance and flexibility.\r\n");
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine();
                Parent p = new Parent();
                Child c = new Child();
                Parent p1 = new Child();
            }
        }
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("Parent Constructor Called");
            }

            private void FinancialDocs()
            {

            }
            public void Print()
            {
                Console.WriteLine("Hello from Parent Class");
            }
            protected void DriveCar()
            {

            }
        }
        class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("Child Constructor Called");
            }
            public void CallPrintFunction()
            {
                base.Print();
                this.Print();
                DriveCar();
            }
            new void Print()
            {
                Console.WriteLine("Hello from Child Class");
            }
        }
        class SubChild : Parent
        {
            public void Subchild()
            {
                Print();

            }
        }
        class SubChild1 : SubChild
        {
            public void Subchild1()
            {
                Console.WriteLine("Hello From SubChild Class");

            }
        }
        #endregion



        #region Call Parent Class Parameterized Constructor
        class A
        {
            public A()
            {
                Console.WriteLine("A : Default Constructor Called ");
            }
            public A(string Name)
            {
                Console.WriteLine("A : Parameterized Constructor Called ");
            }
        }

        class B : A
        {
            public B() : base("Manoj")
            {

                Console.WriteLine("B : Default Constructor Called ");
            }
            public B(int Id)
            {
                Console.WriteLine("B : Parameterized Constructor Called ");

            }
        }


        class MyClass
        {
            public void Manoj()
            {
                B obj = new B();
            }
        }




        #endregion



        #region Sealed Class - To Block the Inheritance of the Class
        sealed class GetPrivateData
        {
            public void GetPropertyDocument()
            {

            }
        }

        class FindPropertyDocs//: GetPrivateData 
        {
            public void TryToGetDocs()
            {
                GetPrivateData obj = new GetPrivateData();
                obj.GetPropertyDocument();
            }
        }

        #endregion
}
