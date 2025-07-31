using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp
{
    internal class ArrayExample
    {
        public int GetArraySizeFromUser()
        {
            int arraySize;
            Console.WriteLine("Enter Array Size");
            arraySize = int.Parse(Console.ReadLine());

            return arraySize;
        }

        public void SingleDimensionArray()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------- Array --------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A variable is used to store a literal value, whereas an array is used to store multiple literal values.\r\n\r\nAn array is the data structure that stores a fixed number of literal values (elements) of the same data type. Array elements are stored contiguously in the memory.\r\n\r\nIn C#, an array can be of three types: single-dimensional, multidimensional, and jagged array. Here you will learn about the single-dimensional array.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("-------------------------------------- Single Dimesion Array --------------------------------------");
            
            #region Syntax
            string[] Cities = { "Pune", "Mumbai", "Nagpur", "Nashik", "Indore" };
            int[] Numbers = { 10, 20, 30, 40 };

            string[] CityNames = new string[5];
            CityNames[4] = "PUNE";
            #endregion


            int size = GetArraySizeFromUser();

            string[] StudentList = new string[size];

            Console.WriteLine("Enter Student Names");
            for (int i = 0; i < size; i++)
            {
                string StudentName = Console.ReadLine();
                StudentList[i] = StudentName;
            }

            Console.WriteLine("Printing Array Elements");

            foreach (string student in StudentList)
            {
                string UserRole = "Normal User";

                if (student.ToLower().Equals("nikhil"))
                {
                    UserRole = "Super Admin";
                }
                Console.WriteLine("{0} - {1}", student.ToUpper(), UserRole);
            }
        }

        public void _2DArray()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------- Array --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------- 2D Array --------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("It contains both rows and columns of elements (like matrix). In 2-D array, each row contains same no. of elements");
            Console.WriteLine();
            Console.WriteLine("int[] Obj=new int[3];\r\nMembers of Arrays (Properties)\r\nObj.Length –return total length of array\r\nObj.Rank – Get the number of dimensions of the array\r\nObj.GetLength(0)- Returns row size( total number of rows)\r\nObj.GetLength(1)- Returns column size( total number of columns)\r\nObj. GetLowerBound(0)- Returns the index of first element of rows\r\nObj. GetLowerBound(1)- Returns the index of first element of columns\r\n");
            Console.ForegroundColor = ConsoleColor.White;
            int Rows, Columns;

            Console.Write("Enter Number of Rows : ");
            Rows = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Columns : ");
            Columns = int.Parse(Console.ReadLine());

            int[,] NumberMatrix = new int[Rows,Columns];

            Console.WriteLine("Enter Elements of the Array");

            for (int i=0; i < Rows; i++)
            {
                for(int j=0; j < Columns; j++) 
                {
                    Console.Write("NumberMatrix[{0},{1}]=",i,j);
                    NumberMatrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Printing 2D Array");

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    //Console.WriteLine(NumberMatrix[i,j] + "\t");
                    Console.Write("{0} {1}", NumberMatrix[i,j], "\t");
                }
                Console.WriteLine();
            }
        }

        public void StudentRegistration() 
        {
            Student student1 = new Student();
            student1.Address = "Pune";
            student1.DOB = DateTime.Now;
            student1.Education = "Msc";
            student1.Email = "student1@gmail.com";
            student1.Gender = "Male";
            student1.ID = 10;
            student1.Name = "Manoj";
            student1.PhoneNumber = "+91 8796124848";


            Student student2 = new Student();
            student2.Address = "Mumbai";
            student2.DOB = DateTime.Now;
            student2.Education = "Bsc";
            student2.Email = "student2@gmail.com";
            student2.Gender = "Female";
            student2.ID = 20;
            student2.Name = "Patil";
            student2.PhoneNumber = "+91 2938923748";


            Student student3 = new Student();
            student3.Address = "Delhi";
            student3.DOB = DateTime.Now;
            student3.Education = "Mechanical";
            student3.Email = "student3@gmail.com";
            student3.Gender = "Female";
            student3.ID = 30;
            student3.Name = "Sujata";
            student3.PhoneNumber = "+91 7483783743";

            Student[] studentList = new Student[3];
            studentList[0] = student1;
            studentList[1] = student2;
            studentList[2] = student3;

            Console.WriteLine("______________Printing Student List______________");
            Console.WriteLine("______________________________________");
            Console.WriteLine("ID   Name    PhoneNumber     Email");
            Console.WriteLine("______________________________________");
            foreach (Student student in studentList)
            {
                Console.WriteLine("{0}  {1} {2} {3}", student.ID, student.Name, student.PhoneNumber, student.Email);
            }
        }

        public void DynamicJaggedArray()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------- Array --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------- Jagged Array --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Jagged array is an array of 1-D array.\r\nIn 2-D array each row contains same number of columns where as in Jagged array, each row contents different no. of columns.\r\nA jagged array is initialized with two square brackets [][]. The first bracket specifies the size of an array, and the second bracket specifies the dimensions of the array which is going to be stored.\r\n\r\nint[][] jArray1 = new int[2][]; // two single-dimensional arrays \r\nint[][,] jArray2 = new int[3][,]; // can include three two-dimensional arrays\r\n\r\n\r\nint array1= new int[3]{1, 2, 3};\r\nint array2= new int[4]{4, 5, 6, 7 };\r\n\r\nint[][] jArray = new int[2][]; \r\njArray[0] = array1;\r\njArray[1] = array2;\r\n\r\njArray[0][0]; //returns 1\r\njArray[0][1]; //returns 2\r\njArray[0][2]; //returns 3\r\n\r\njArray[1][0]; //returns 4\r\njArray[1][1]; //returns 5\r\njArray[1][2]; //returns 6\r\njArray[1][3]; //returns 7\r\n\r\nOR \r\nfor(int i=0; i<jArray.Length; i++)\r\n{\r\n\tfor(int j=0; j < (jArray[i]).Length; j++)\r\n\t\tConsole.WriteLine(jArray[i][j]);\r\n}\r\n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            int size = GetArraySizeFromUser();
            int[][] jArray = new int[size][];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Size of Internal Array {0} : ", i);
                int internalArraySize = int.Parse(Console.ReadLine());
                int[] innerArray = new int[internalArraySize];
                Console.WriteLine("Enter Element for Internal Array {0}", i);
                for (int j = 0; j < innerArray.Length; j++)
                {
                    innerArray[j] = int.Parse(Console.ReadLine());
                }
                jArray[i] = innerArray;
            }
            Console.WriteLine("Printing Dynamic Jagged Array");

            for (int i = 0; i < jArray.Length; i++)
            {
                Console.Write("Row {0}: ", i);
                for (int j = 0; j < jArray[i].Length; j++)
                {
                    Console.Write("{0} ", jArray[i][j]);
                }
                Console.WriteLine();
            }
        }

        public void BinarySearchExample()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------- Binary Search --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Binary Search (Array, Elements) :- ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Searches for given element in given array using binary search logic and returns the index of that element if found. Otherwise returns a negative value.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            int size = GetArraySizeFromUser();
            int[] NumberCollection = GetIntegerArray(size);
            Console.Write("Enter Element to Search : ");
            int searchElement = int.Parse(Console.ReadLine());
            int Result = Array.BinarySearch(NumberCollection, searchElement);
            if (Result >= 0)
            {
                Console.WriteLine("Your Element Found At Position {0}", Result);
            }
            else 
            {
                Console.WriteLine("Element not Found");
            }
        }

        public int[] GetIntegerArray(int size) 
        {
            int[] NumericArray = new int[size];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < NumericArray.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                NumericArray[i] = int.Parse(Console.ReadLine());
            }
            return NumericArray;
        }

        public void ClearArrayElements()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------- Clear Array --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Clear(Array, StartIndex, n) :- ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Clears ‘n’ number of elements starting from given ‘StartIndex’ in the given array.\r\nI.e. those values are set to the value 0.\r\n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            int size = GetArraySizeFromUser();
            int[] NumberCollection = GetIntegerArray(size);

            Console.Write("Enter Number of Elements to Clear : ");
            int NumbersToClear = int.Parse(Console.ReadLine());

            Console.Write("Enter Starting Index Number to Clear the {0} Elements : ", NumbersToClear);
            int StartIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("Array Before Clearing the Elements");
            Console.Write("[");
            foreach (int Number in NumberCollection)
            {
                Console.Write("{0},\t", Number);
            }
            Console.Write(" ]");

            Console.WriteLine();
            if ((NumbersToClear + StartIndex) > NumberCollection.Length)
            {
                Console.WriteLine("Invalid Inputs. Please correct your input and Try again later.");
            }
            else
            {
                Array.Clear(NumberCollection, StartIndex, NumbersToClear);
                Console.WriteLine("Array After Clearing the Elements");
                Console.Write("[");

                foreach (int Number in NumberCollection)
                {
                    Console.Write("{0},\t", Number);
                }
                Console.Write(" ]");
            }
        }

        public void PrintArray(int[] array)
        {
            Console.Write("[");
            foreach (int Number in array)
            {
                Console.Write("{0},\t", Number);
            }
            Console.Write(" ]");
        }

        public void CopyArrayElements()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------- Copy Array --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Copy(S.Array, S.Index, D.Array, D.Index, n) :- ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Copies n number of elements from S.Array starting from the index S.Index to D.Array staring from the index D.Index");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            int SourceArraySize = GetArraySizeFromUser();
            int[] SourceArray = GetIntegerArray(SourceArraySize);

            int DestinationArraySize = GetArraySizeFromUser();
            int[] DestinationArray = GetIntegerArray(DestinationArraySize);
            Console.WriteLine("Source Array");
            PrintArray(SourceArray);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Destination Array");
            PrintArray(DestinationArray);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            Console.Write("Enter Number of Elements to Copy : ");
            int NumberOfElementsToCopy = int.Parse(Console.ReadLine());

            Console.Write("Enter Source Array Index Number to Copy the Elements :");
            int SourceIndexNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Destination Array Index Number to Paste the Copied Elements : ");
            int DestinationIndexNumber = int.Parse(Console.ReadLine());

            if ((NumberOfElementsToCopy + SourceIndexNumber) > SourceArray.Length ||
                (NumberOfElementsToCopy + DestinationIndexNumber) > DestinationArray.Length)
            {
                Console.WriteLine("Invalid Inputs");
            }
            else
            {
                Array.Copy(SourceArray, SourceIndexNumber, DestinationArray, DestinationIndexNumber, NumberOfElementsToCopy);
                PrintArray(DestinationArray);
            }
        }

        public void IndexOfExample()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------- indexOf Array --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("indexOf(Array,element) :- ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Searches for a given element in an array using linear search and returns the index of first occurrence of an element if it is found otherwise returns negative value.  ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            int size = GetArraySizeFromUser();
            int[] Numbers = GetIntegerArray(size);
            Console.Write("Enter Element to Search : ");
            int searchElement = int.Parse(Console.ReadLine());
            int Result = Array.IndexOf(Numbers, searchElement);
            int LastResult = Array.LastIndexOf(Numbers, searchElement);
            if (Result >= 0)
            {
                Console.WriteLine("Element found at location {0}", Result);
            }
            else
            {
                Console.WriteLine("Element Not Found");
            }

            if (LastResult >= 0)
            {
                Console.WriteLine("Last Occurance of the Element found at location {0}", LastResult);
            }
            else
            {
                Console.WriteLine("Element Not Found");
            }
        }

        public void GetInputInSingleLine()
        {
            Console.WriteLine("Enter elements separated by Comma");
            string userInput = Console.ReadLine();
            string[] array = userInput.Split(',');
            int[] Numbers = new int[array.Length];
            int i = 0;
            foreach (string element in array)
            {
                if (!string.IsNullOrEmpty(element))
                {
                    Numbers[i] = Convert.ToInt32(element.Trim());

                }
                i++;
            }

            Console.Write("Enter Number of Rows and Columns separated by comma :   ");//3,4
            string rowsAndColumns = Console.ReadLine();
            int Rows = int.Parse(rowsAndColumns.Split(',')[0].Trim());
            int Column = int.Parse(rowsAndColumns.Split(',')[1]);

        }

        public void ReverseArray()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------- Reverse Array --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Reverse(array) :- ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Reverse the elements in given array");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            int size = GetArraySizeFromUser();
            int[] Numbers = GetIntegerArray(size);
            Console.WriteLine("Printing Array Before Reverse");
            PrintArray(Numbers);
            Array.Reverse(Numbers);
            Console.WriteLine();
            Console.WriteLine("Printing Array After Reverse");
            PrintArray(Numbers);
        }

        public void SortArrayExample()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------- Sort Array --------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sort(array) :- ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sorts the elements of array in ascending order. ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            int size = GetArraySizeFromUser();
            int[] Numbers = GetIntegerArray(size);

            Console.WriteLine("Printing Array Before Sort");
            PrintArray(Numbers);
            Console.WriteLine();

            Array.Sort(Numbers);
            Console.WriteLine("Sorted Array in Ascending Order");
            PrintArray(Numbers);
            Console.WriteLine();
            Console.WriteLine("Sorted Array in Descending Order");
            Array.Reverse(Numbers);
            PrintArray(Numbers);
        }
    }
}