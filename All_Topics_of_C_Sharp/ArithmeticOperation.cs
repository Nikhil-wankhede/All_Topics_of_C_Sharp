using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp
{
    internal class ArithmeticOperation
    {
        int Number1, Number2, Result;

        private void GetInputFromUser()
        {
            Console.Write("Enter Number 1 : ");
            Number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Number 2 : ");
            Number2 = int.Parse(Console.ReadLine());
        }

        public void Addition()
        {
            GetInputFromUser();

            string name = "Nikhil";
            string surname = "Wankhede";

            string FullName = name + surname;

            Result = Number1 + Number2;

            Console.WriteLine("Addition of {0} and {1} is : {2}", Number1, Number2, Result);
        }

        public void Substraction() 
        {
            GetInputFromUser();

            Result = Number1 - Number2;
            Console.WriteLine("Substraction of {0} and {1} is : {2}", Number1, Number2, Result);
        }
        public void Multiplication()
        {
            GetInputFromUser();

            Result = Number1 * Number2;
            Console.WriteLine("Multiplication of {0} and {1} is : {2}", Number1, Number2, Result);
        }
        public void Division()
        {
            GetInputFromUser();

            Result = Number1 / Number2;
            Console.WriteLine("Division of {0} and {1} is : {2}", Number1, Number2, Result);
        }

        public void Moduls()
        {
            GetInputFromUser();

            Result = Number1 % Number2;
            Console.WriteLine("Moduls of {0} and {1} is : {2}", Number1, Number2, Result);
        }

        public void Increment()
        {
            GetInputFromUser();

            Console.WriteLine("Increment of {0} and {1} is : {2} and {3}", Number1, Number2, ++Number1, ++Number2);
        }

        public void Decrement()
        {
            GetInputFromUser();

            Console.WriteLine("Decrement of {0} and {1} is : {2} and {3}", Number1, Number2, --Number1, --Number2);
        }

        public void InitializeArithmaticOperation()
        {
            Console.WriteLine("_______Arithmatic Operations Menu________");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Moduls");
            Console.WriteLine("6. Increment");
            Console.WriteLine("7. Decrement");

            Console.Write("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Substraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Moduls();
                    break;
                case 6:
                    Increment();
                    break;
                case 7:
                    Decrement();
                    break;
                default:
                    Console.WriteLine("Choose only 1 to 7");
                    break;
            }
        }
    }
}
