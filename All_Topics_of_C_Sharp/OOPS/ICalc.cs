using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp.OOPS
{
    internal interface ICalc
    {
        int Addition(int a, int b);
        int Division(int a, int b);
        void PrintName();
    }
    interface IAddition
    {
        int GetTotal(int a, int b);
        int Addition(int a, int b);
    }


    class ImplementInterface : ICalc, IAddition
    {
        #region Implicit Interface Implementation
        //public int Addition(int a, int b)
        //{
        //    return a + b;
        //}
        //public int Division(int a, int b)
        //{
        //    return a / b;
        //}
        //public void PrintName()
        //{
        //    Console.WriteLine("Manoj");
        //}

        //public int GetTotal(int Number1, int Number2)
        //{
        //    return Number1 + Number2;
        //}
        #endregion

        #region Explicit Interface Implementation

        int ICalc.Addition(int a, int b)
        {
            return a + b + 10;
        }

        int IAddition.Addition(int a, int b)
        {
            return a + b;
        }

        int ICalc.Division(int a, int b)
        {
            throw new NotImplementedException();
        }

        int IAddition.GetTotal(int a, int b)
        {
            throw new NotImplementedException();
        }

        void ICalc.PrintName()
        {
            throw new NotImplementedException();
        }

        #endregion

    }

    class CallInterfaceMethod
    {
        public void CallInterfaceMethods()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------- Interface -----------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("An interface looks like a class, but has no implementation. The only thing it contains are declarations of events, methods and/or properties. The reason interfaces only provide declarations is that structures and classes inherit them, which must provide an implementation for each interface member declared.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;



            ImplementInterface obj = new ImplementInterface();
            int ICalcResult = ((ICalc)obj).Addition(20, 30);
            int IAdditionResult = ((IAddition)obj).Addition(20, 30);

            Console.WriteLine("IAddition : {0}", IAdditionResult);
            Console.WriteLine("ICalc : {0}", ICalcResult);
        }
    }
}
