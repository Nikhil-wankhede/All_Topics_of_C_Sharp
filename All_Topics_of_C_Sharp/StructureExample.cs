using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp
{
    struct EmployeeStructure
    {
        public int ID;
        public string Name;

        public void PrintName()
        {
            Console.WriteLine("Helllooo !!");
        }
    }

    class EmployeeClass
    {
        public int ID;
        public string Name;
        public void PrintName(string name)
        {
            Console.WriteLine("Helllooo !!");
        }
    }
    internal class StructureExample
    {
        public void InitializeStructExample()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------- Structure ---------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A structure is the user-defined type that contains the list of elements of dissimilar data type OR\r\nA structure is the collection of dissimilar data elements or heterogeneous data elements\r\nA structure is a value type that contains both data members and member functions together.\r\n\r\nSyntax\r\n[access modifier] struct StructName\r\n{\r\n\t<Data Members>;\r\n\t< Member functions>;\r\n\r\n}\r\nstruct Customer\r\n{\r\n\tInt Cust-No;\r\nString CustName;\r\ngetCustomer()\r\n{\r\n}\r\n}\r\n\r\n\r\n\r\nWhat is the difference between a struct and a class in C# \r\nClass and struct are both user-defined data types, but have some major differences: \r\n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Strut");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("•The struct is a value type in C# and it inherits from System.Value Type. \r\n• Struct is usually used for smaller amounts of data. \r\n• Struct can’t be inherited from other types. \r\n• A structure can't be abstract. \r\n• No need to create an object with a new keyword. \r\n• Do not have permission to create any default constructor. \r\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Class");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("•The class is a reference type in C# and it inherits from the System.Object Type. \r\n• Classes are usually used for large amounts of data. \r\n• Classes can be inherited from other classes. \r\n• A class can be an abstract type. \r\n• We can create a default constructor. \r\n");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.White;
            EmployeeStructure emp = new EmployeeStructure();
            emp.ID = 100;
            emp.Name = "Manoj";

            Console.WriteLine("Name : {0}", emp.Name);
            EmployeeStructure emp2 = emp;
            emp2.Name = "Patil";
            Console.WriteLine("Name : {0}", emp.Name);

            //=================================================================

            EmployeeClass empclass1 = new EmployeeClass();
            empclass1.ID = 200;
            empclass1.Name = "MANOJ";

            Console.WriteLine("Name : {0}", empclass1.Name);
            Console.WriteLine("ID : {0}", empclass1.ID);


            EmployeeClass empclass2 = empclass1;
            empclass2.ID = 500;
            empclass2.Name = "Patil";
            Console.WriteLine("Name : {0}", empclass1.Name);
            Console.WriteLine("ID : {0}", empclass1.ID);


        }
    }
}
