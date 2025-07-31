using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.OOPS
{
    internal class MethodOverloadingExample
    {
        public void InitializeMethodOverloadingExample()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------- Polymorphism --------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************** Compile Time Polymorphism **************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Method Overloading Example :- ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("defining multiple methods with the same name but with different parameters within the same class.");
            Console.WriteLine();

            Student student = new Student();
            student.Address = "Pune";
            student.Name = "Manoj";

            Addition(student);

            Addition("Manoj", 10, 30);
        }

        public void Addition(string name, int a, int b)
        {
            int c = a + b;
        }

        public void Addition(int a, string name, int b)
        {
            int c = a + b;
        }
        public void Addition(Student student)
        {

        }
        public void Addition(Student[] students)
        {

        }

        public void Addition(int a, int b)
        {
            int c = a + b;
        }
        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }
        public void Addition(params int[] Numbers)
        {

        }
    }
}
