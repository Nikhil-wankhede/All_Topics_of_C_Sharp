using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using All_Topics_of_C_Sharp.OOPS;
using All_Topics_of_C_Sharp.COLLECTIONS;

namespace All_Topics_of_C_Sharp
{
    internal class Program
    {
        static unsafe void Main(string[] args)
        {

            //char a = 'A';
            //char* pointer = &a;
            //Console.WriteLine(*pointer);
            //ArrayExample obj = new ArrayExample();
            //obj.GetInputInSingleLine();

            PrintMenu();

            
            SelectandExecuteMenuOption();


            Console.ReadLine();
        }

        public static void SelectandExecuteMenuOption()
        {
            Console.Write("Enter your Choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ArithmeticOperation objMath = new ArithmeticOperation();
                    Console.Clear();
                    objMath.InitializeArithmaticOperation();
                    break;
                case 2:
                    ControlStatements objIfElse = new ControlStatements();
                    objIfElse.IfElse();
                    break;
                case 3:
                    ControlStatements objWhile = new ControlStatements();
                    objWhile.WhileLoop();
                    break;
                case 4:
                    ControlStatements objDoWhileLoop = new ControlStatements();
                    objDoWhileLoop.DoWhileLoop();
                    break;
                case 5:
                    ControlStatements objForLoop = new ControlStatements();
                    objForLoop.ForLoop();
                    break;
                case 6:
                    ControlStatements objForEach = new ControlStatements();
                    objForEach.ForEachExample();
                    break;
                case 7:
                    ArrayExample objarrayExample = new ArrayExample();
                    objarrayExample.SingleDimensionArray();
                    break;
                case 8:
                    ArrayExample _2d = new ArrayExample();
                    _2d._2DArray();
                    break;
                case 9:
                    ControlStatements objStudnet_Marksheet = new ControlStatements();
                    objStudnet_Marksheet.Studnet_Marksheet();
                    break;
                case 10:
                    ArrayExample objStudentReg = new ArrayExample();
                    objStudentReg.StudentRegistration();
                    break;
                case 11:
                    ArrayExample objJaggedArray = new ArrayExample();
                    objJaggedArray.DynamicJaggedArray();
                    break;
                case 12:
                    ArrayExample objBinarySearch = new ArrayExample();
                    objBinarySearch.BinarySearchExample();
                    break;
                case 13:
                    ArrayExample objClear = new ArrayExample();
                    objClear.ClearArrayElements();
                    break;
                case 14:
                    ArrayExample objCopy = new ArrayExample();
                    objCopy.CopyArrayElements();
                    break;
                case 15:
                    ArrayExample objIndexOf = new ArrayExample();
                    objIndexOf.IndexOfExample();
                    break;
                case 16:
                    ArrayExample objGetInputSingleLine = new ArrayExample();
                    objGetInputSingleLine.GetInputInSingleLine();
                    break;
                case 17:
                    ArrayExample objReverseArray =new ArrayExample();
                    objReverseArray.ReverseArray();
                    break;
                case 18:
                    ArrayExample objSortArray = new ArrayExample();
                    objSortArray.SortArrayExample();
                    break;
                case 19:
                    ParametersExample objparametersExample = new ParametersExample();
                    objparametersExample.InitializeParameterExample();
                    break;
                case 20:
                    StructureExample objstructureExample = new StructureExample();
                    objstructureExample.InitializeStructExample();
                    break;
                case 21:
                    EnumExample objinitializeEnumExample = new EnumExample();
                    objinitializeEnumExample.Initialize_Enum_Example();
                    break;
                case 22:
                    Inheritance_Example obj = new Inheritance_Example();
                    obj.InitializeInheritanceExample();
                    break;
                case 23:
                    MethodoverridingExample objmethodoverridingExample = new MethodoverridingExample();
                    objmethodoverridingExample.InitializeMethodOverridingExample();
                    break;
                case 24:
                    MethodOverloadingExample objmethodOverloadingExample = new MethodOverloadingExample();
                    objmethodOverloadingExample.InitializeMethodOverloadingExample();
                    break;
                case 25:
                    AccessModifiers objaccessModifiers = new AccessModifiers();
                    objaccessModifiers.CheckPassword();
                    break;
                case 26:
                    UseOfClassMembers objuseOfClassMembers = new UseOfClassMembers();
                    objuseOfClassMembers.AccessMembers();
                    break;
                case 27:
                    CheckConstructor objChk = new CheckConstructor();
                    objChk.RunMethod();
                    break;
                case 28:
                    CallPrivateCtor objPrivateConstructor = new CallPrivateCtor();
                    objPrivateConstructor.RunPrivateCtor();
                    break;
                case 29:
                    CallInterfaceMethod objcallInterfaceMethod = new CallInterfaceMethod();
                    objcallInterfaceMethod.CallInterfaceMethods();
                    break;
                case 30:
                    CalledGarbaseCollector objDestruct = new CalledGarbaseCollector();
                    objDestruct.Call_GC();
                    break;
                case 31:
                    //CalledGarbaseCollector objDestruct = new CalledGarbaseCollector();
                    //objDestruct.Call_GC();
                    break;
                case 32:
                    UseOfExtensionMethod objextensionMethod = new UseOfExtensionMethod();
                    objextensionMethod.Test();
                    break;
                case 33:
                    ArrayListExample objArrayListExample = new ArrayListExample();
                    objArrayListExample.InitializeArrayListExample();
                    break;
                case 34:
                    ListExample objlistExample = new ListExample();
                    objlistExample.InitializeListExample();
                    break;
                case 35:
                    DictionaryExample objdictionaryExample = new DictionaryExample();
                    objdictionaryExample.InitializeDictionryExample();
                    break;
                case 36:
                    HashTableExample objhashTableExample = new HashTableExample();
                    objhashTableExample.InitializeHashTableExample();
                    break;
                case 37:
                    SortedListExample objsortedListExample = new SortedListExample();
                    objsortedListExample.InitializeSortedListExample();
                    break;
                case 38:
                    StackExample objstackExample = new StackExample();
                    objstackExample.InitializeStackExample();
                    break;
                case 39:
                    QueueExample objqueueExample = new QueueExample();
                    objqueueExample.InitializeQueueExample();
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Try again.");
                    break;
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("__________________ Main Menu __________________");
            Console.WriteLine("1.  Arithmatic Operation");
            Console.WriteLine("2.  If-Else Statement");
            Console.WriteLine("3.  While loop");
            Console.WriteLine("4.  Do-While loop");
            Console.WriteLine("5.  For loop");
            Console.WriteLine("6.  ForEach loop");
            Console.WriteLine("7.  Single Dimension Array");
            Console.WriteLine("8.  Two Dimension Array");
            Console.WriteLine("9.  Student Marksheet");
            Console.WriteLine("10. Student Registration");
            Console.WriteLine("11. Jagged Array");
            Console.WriteLine("12. Binary Search Example");
            Console.WriteLine("13. Clear Array Example");
            Console.WriteLine("14. Copy Array Example");
            Console.WriteLine("15. IndexOf Array Example");
            Console.WriteLine("16. Get Input In Single Line");
            Console.WriteLine("17. Reverse Array Example");
            Console.WriteLine("18. Sort Array Example");
            Console.WriteLine("19. Initialize Parameters");
            Console.WriteLine("20. Structure Examples");
            Console.WriteLine("21. Enumeration Examples");
            Console.WriteLine("22. Inheritance Examples");
            Console.WriteLine("23. Method Overriding Examples");
            Console.WriteLine("24. Method Overloading Examples");
            Console.WriteLine("25. Access Modifiers ");
            Console.WriteLine("26. Instancec and Static Members");
            Console.WriteLine("27. Constructor Examples");
            Console.WriteLine("28. Private Constructor Examples");
            Console.WriteLine("29. Interface Methods");
            Console.WriteLine("30. Destructor Examples");
            Console.WriteLine("31. Abstract Class Examples");
            Console.WriteLine("32. Extension Method Examples");
            Console.WriteLine("33. COLLECTIONS - Array List Examples");
            Console.WriteLine("34. COLLECTIONS - List Examples");
            Console.WriteLine("35. COLLECTIONS - Dictionary Examples");
            Console.WriteLine("36. COLLECTIONS - Hash Table Examples");
            Console.WriteLine("37. COLLECTIONs - Sorted List Examples");
            Console.WriteLine("38. COLLECTIONS - Stack Examples");
            Console.WriteLine("39. COLLECTIONS - Queue Examples");
        }
    }
}
