using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.OOPS
{
    class ConstructorExample
    {
        public List<Student> studentList { get; set; }

        public List<Student> list = new List<Student>();
        public static int StaticProperty { get; set; }

        public int ID { get; set; }

        #region Default Constructor

        public ConstructorExample() //: this("", 10)
        {
            Console.WriteLine("Default Constructor Called ");

            studentList = new List<Student>();
        }

        #endregion

        #region Parameterized Constructor

        public ConstructorExample(string Name)
        {

        }
        public ConstructorExample(int ID)
        {

        }
        public ConstructorExample(string Name, int ID)
        {

        }

        #endregion

        #region Copy Contructor

        public ConstructorExample(ConstructorExample existingObject)
        {
            list = existingObject.list;
            studentList = existingObject.studentList;
            ID = existingObject.ID;
        }


        #endregion

        #region Static Constructor
        static ConstructorExample()
        {
            Console.WriteLine("Static Constructor Called ");
        }
        #endregion

    }

    class CheckConstructor
    {
        public void RunMethod()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------- Memory Initialization ---------------------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("**************** Constructor ****************");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("A constructor is a special method that is automatically invoke when we create an instance of the class. The main purpose of creating a constructor is to initialize the private fields of the class.\r\nWhen we have not creating any constructors, then compiler will create a default constructor which initializes all the numerical fields value to “zero” and all object and string fields to a value “NULL”\r\n\tConstructor name is same as Class name\r\n\tConstructor does not have any return type\r\n\tConstructor should be defined within the public section\r\n\tA class can have any no. of constructor (Method Overloading)\r\n\tIf constructor is static then we cannot pass the arguments to the constructor.\r\n");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Types of Constructors\r\n1.\tDefault Constructor\r\n2.\tParameterized Constructor\r\n3.\tCopy Constructor\r\n4.\tStatic Constructor\r\n5.\tPrivate Constructor\r\n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Default Constructor :- ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A constructor without any arguments or parameter is called as default constructor. ");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Parameterized Construtor :- ");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("A constructor with at least one parameter is called parameterized constructor");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Copy Constructor :- ");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("A parameterized constructor with at least one parameter of same class type is called as copy constructor.\r\nThe main advantage of copy constructor is copying the content of existing instance to new instance.\r\nABC obj = new ABC();\r\n            obj.MyName = \"MANOJ\";\r\n            obj.MyAge = 20;\r\nABC obj3 = new ABC(obj);\r\n");
            Console.WriteLine();

            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Static Constructor :- ");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("When we define a constructor as a static then it will be invoked only once during the creation of first instance of the class.\r\nStatic constructors have the following properties:\r\n\tA static constructor does not take access modifiers or have parameters.\r\n\tA static constructor is called automatically to initialize the class before the first instance is created or any static members are referenced.\r\n\tA static constructor cannot be called directly. (Refer https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.runtimehelpers.runclassconstructor?view=net-5.0 ) \r\n\tThe user has no control on when the static constructor is executed in the program.\r\n\tA typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.\r\n\tStatic constructors are also useful when creating wrapper classes for unmanaged code, when the constructor can call the LoadLibrary method.\r\n");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.White;


            ConstructorExample.StaticProperty = 100;
            ConstructorExample objParameter = new ConstructorExample();
            ConstructorExample obj = new ConstructorExample();
            Student me = new Student();
            me.Name = "Manoj";
            me.ID = 100;

            Student student = new Student();
            student.Name = "Ganesh";
            student.ID = 300;

            obj.list.Add(me);
            obj.studentList.Add(student);
            obj.ID = 300;

            ConstructorExample obj2 = new ConstructorExample(obj);
            obj2.ID = 5000;
        }

    }
}
