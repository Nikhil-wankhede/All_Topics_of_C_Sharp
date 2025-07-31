using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp
{
    internal class ControlStatements
    {
        public void IfElse()
        {
            Console.Clear();
            Console.WriteLine("Conditional Control Structures");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------- If, If-Else, Nested If-Else Statements --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("If Statements :- ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The if statement contains a boolean condition followed by a single or multi-line code block to be executed. At runtime, if a boolean condition evaluates to true, then the code block will be executed, otherwise not.");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Else If Statements :- ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Multiple else if statements can be used after an if statement. It will only be executed when the if condition evaluates to false. So, either if or one of the else if statements can be executed, but not both.");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Else Statements :- ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The else statement can come only after if or else if statement and can be used only once in the if-else statements. The else statement cannot contain any condition and will be executed when all the previous if and else if conditions evaluate to false.");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Nested If Statements :-");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("C# supports if else statements inside another if else statements. This are called nested if else statements. The nested if statements make the code more readable.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter any Number : ");
            int number = int.Parse(Console.ReadLine());

            if (number > 70)
            {
                Console.WriteLine("Grade A");
            }
            else
            {
                if (number < 50)
                {
                    if (number < 35)
                    {
                        Console.WriteLine("Failed !!!");
                    }
                    else
                    {
                        Console.WriteLine("Grade C");
                    }
                }
                else 
                {
                    Console.WriteLine("Grade B");
                }
            }
        }

        public void WhileLoop()
        {
            Console.Clear();
            Console.WriteLine("Loop Control Structure( Iterative)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------- While Loop --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Provides the while loop to repeatedly execute a block of code as long as the specified condition returns true.\r\n\r\nSyntax:\r\nWhile(condition)\r\n{\r\n    //code block\r\n}");
            Console.WriteLine();
            Console.WriteLine("The while loop starts with the while keyword, and it must include a boolean conditional expression inside brackets that returns either true or false. It executes the code block until the specified conditional expression returns false.\r\n\r\nThe for loop contains the initialization and increment/decrement parts. When using the while loop, initialization should be done before the loop starts, and increment or decrement steps should be inside the loop.");
            Console.WriteLine("Ensure that the conditional expression evaluates to false or exit from the while loop on some condition to avoid an infinite loop. The following loop is missing an appropriate condition or break the loop, which makes it an infinite while loop.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            int Number, Reverse = 0, Rem;
            Console.Write("Enter any number : ");
            Number = int.Parse(Console.ReadLine());
            //Number = 45;
            while (Number > 0)
            {
                Rem = Number % 10;
                Reverse = Reverse * 10 + Rem;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse Number is : {0}", Reverse);
            
        }

        public void DoWhileLoop()
        {
            Console.Clear ();
            Console.WriteLine("Loop Control Structure( Iterative)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("-------------------------------------- Do While Loop --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The do while loop is the same as while loop except that it executes the code block at least once.\r\n\r\nSyntax:\r\ndo\r\n{\r\n    //code block\r\n\r\n\r\n} while(condition);");
            Console.WriteLine();
            Console.WriteLine("The do-while loop starts with the do keyword followed by a code block and a boolean expression with the while keyword. The do while loop stops execution exits when a boolean condition evaluates to false. Because the while(condition) specified at the end of the block, it certainly executes the code block at least once. Specify initialization out of the loop and increment/decrement counter inside do while loop.");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("Enter any number to Print table");
            int Number = int.Parse(Console.ReadLine());

            if (Number > 0)
            {
                int Counter = 1, TableValue;
                do
                {
                    TableValue = Number * Counter;
                    Console.WriteLine("{0} * {1} = {2}", Number, Counter, TableValue);
                    Counter++;
                }
                while (Counter <= 10);
            }
        }

        public void ForLoop()
        {
            Console.Clear ();
            Console.WriteLine("Loop Control Structure( Iterative)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------- For Loop --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Here, you will learn how to execute a statement or code block multiple times using the for loop, structure of the for loop, nested for loops, and how to exit from the for loop.\r\n\r\nThe for keyword indicates a loop in C#. The for loop executes a block of statements repeatedly until the specified condition returns false.\r\n\r\nSyntax:\r\nfor (initializer; condition; iterator)\r\n{\r\n    //code block \r\n}\r\nThe for loop contains the following three optional sections, separated by a semicolon:\r\n\r\nInitializer: The initializer section is used to initialize a variable that will be local to a for loop and cannot be accessed outside loop. It can also be zero or more assignment statements, method call, increment, or decrement expression e.g., ++i or i++, and await expression.\r\n\r\nCondition: The condition is a boolean expression that will return either true or false. If an expression evaluates to true, then it will execute the loop again; otherwise, the loop is exited.\r\n\r\nIterator: The iterator defines the incremental or decremental of the loop variable.");
            Console.WriteLine("You can also exit from a for loop by using the break keyword.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            string DefaultPassword = "manoj", UserInputPassword = string.Empty;
            Console.WriteLine("Enter Your System Password : ");
            int i = 1, MaxTryLimit = 3;
            for (i = 1; i <= MaxTryLimit; i++)
            {
                UserInputPassword = Console.ReadLine();
                //if (DefaultPassword==UserInputPassword)
                if (DefaultPassword.Equals(UserInputPassword))
                {
                    Console.WriteLine("Welcome Authorized User !!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Password. Please Try again. {0} attempts remaining", MaxTryLimit - i);
                }
            }
            if (i.Equals(MaxTryLimit + 1)) //i==4
            {
                Console.WriteLine("You have entered wrong password 3 times. Your username is disabled !!");
            }
        }

        public void ForEachExample()
        {
            Console.Clear();
            Console.WriteLine("Loop Control Structure(Iterative)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("-------------------------------------- For Each Loop --------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            string[] Cities = { "Mumbai", "Pune", "Nashik" };
            foreach (string city in Cities)
            {
                Console.Write(city + "\t");
            }

            ControlStatements obj = new ControlStatements();
            int[] NumberCollection = new int[5];
            NumberCollection[0] = 10;
            NumberCollection[1] = 20;
            NumberCollection[2] = 30;
            NumberCollection[3] = 40;
            NumberCollection[4] = 50;

            //int[] Numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine();
            foreach (int number in NumberCollection)
            {
                Console.Write(number + "\t");
            }



        }

        public void Studnet_Marksheet()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------- Display Student Marksheets --------------------------------------");
            //Variable Decleration for collection of different data
            int RollNo, Enrollement_No, Obtained_Marks, Physics, Chemistry, Mathematics, Biology, Electronics, Computer_Scicence;

            //Decleration of string variable to store student data
            string Studnet_Name, College_Name, University_Name;

            //Getting the student's name
            Console.WriteLine("Enter the Student Name :- ");
            Studnet_Name = Console.ReadLine();

            //Getting the student's college name
            Console.WriteLine("Enter Student College Name :- ");
            College_Name = Console.ReadLine();

            //Getting the student's university name
            Console.WriteLine("Enter Student University Name :- ");
            University_Name = Console.ReadLine();

            //Getting the student's roll no
            Console.WriteLine("Enter Student Roll No. :- ");
            RollNo = int.Parse(Console.ReadLine());

            //Getting the student's enrollement no
            Console.WriteLine("Enter Student Enrollement No :- ");
            Enrollement_No = int.Parse(Console.ReadLine());

            //Getting the student's physics marks
            Console.WriteLine("Enter Physics Marks :- ");
            Physics = int.Parse(Console.ReadLine());

            //Getting the student's chemistry marks
            Console.WriteLine("Enter Chemistry Marks :- ");
            Chemistry = int.Parse(Console.ReadLine());

            //Getting the student's mathematics marks
            Console.WriteLine("Enter Mathematics Marks :- ");
            Mathematics = int.Parse(Console.ReadLine());

            //Getting the student's biology marks
            Console.WriteLine("Enter Biology Marks :- ");
            Biology = int.Parse(Console.ReadLine());

            //Getting the student's electronics marks
            Console.WriteLine("Enter Electronics Marks :- ");
            Electronics = int.Parse(Console.ReadLine());

            //Getting the student's computer science marks
            Console.WriteLine("Enter Computer Science Marks :- ");
            Computer_Scicence = int.Parse(Console.ReadLine());

            //Adding the obtained marks of the student
            Obtained_Marks = Physics + Chemistry + Mathematics + Biology + Electronics + Computer_Scicence;

            //Decleration of percentage variable
            float percentage = Obtained_Marks / 6.0f;

            //Displaying the whole marksheet of the student 
            Console.WriteLine("------------------------------------- Studnet Marksheet -------------------------------------");

            Console.WriteLine("Studnet Name :- {0}                                    Roll No. :- {1} ", Studnet_Name, RollNo);
            Console.WriteLine("College Name :- {0}                     University Name :- {1}", College_Name, University_Name);
            Console.WriteLine("Enrollement No :- {0}", Enrollement_No);

            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("Subjecs                              Out of Marks                              Obtained Marks");
            Console.WriteLine("Physics                                  100                                         {0}", Physics);
            Console.WriteLine("Chemistry                                100                                         {0}", Chemistry);
            Console.WriteLine("Mathematics                              100                                         {0}", Mathematics);
            Console.WriteLine("Biology                                  100                                         {0}", Biology);
            Console.WriteLine("Electronics                              100                                         {0}", Electronics);
            Console.WriteLine("Computer Science                         100                                         {0}", Computer_Scicence);
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("Total Marks                              600                                         {0}", Obtained_Marks);
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.WriteLine("Overall Percentage :- " + percentage);

            //This block calculate the grades of the studenet
            if (percentage <= 35)
            {
                Console.WriteLine("Grade is :- F");
            }
            else if (percentage >= 34 && percentage <= 39)
            {
                Console.WriteLine("Grade is :- D");
            }
            else if (percentage >= 40 && percentage <= 59)
            {
                Console.WriteLine("Grade is :- C");
            }
            else if (percentage >= 60 && percentage <= 69)
            {
                Console.WriteLine("Grade is :- B");
            }
            else if (percentage >= 70 && percentage <= 89)
            {
                Console.WriteLine("Grade is :- B+");
            }
            else if (percentage >= 80 && percentage <= 90)
            {
                Console.WriteLine("Grade is :- A");
            }
            else if (percentage >= 91)
            {
                Console.WriteLine("Grade is :- A+");
            }
        }
    }
}
