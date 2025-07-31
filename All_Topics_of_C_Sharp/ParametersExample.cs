using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp
{
    internal class ParametersExample
    {
        public void InitializeParameterExample()
        {
            //int n = 20;
            //int result = Addition(n, 30);
            //result = Addition(50, 30);
            //result = Addition(500);

            //int[] myNumberCollection = { 10, 20, 30, 40, 50 };
            //result = Multiplication("Manoj", 10, 12, 12, 12, 12, 12);


            string myName = "Manoj";

            PrintName(ref myName);


            string Surname = "Patil";
            OutPrintName(out Surname);
        }
        public int Addition(int Number1, int Number3 = 200, int Number2 = 100)
        {
            Number1 = 66;
            return Number1 + Number3 + Number2;
        }

        public int Multiplication(string Number, int P, params int[] Numbers)
        {
            int result = 1;
            foreach (int n in Numbers)
            {
                result = result * n;
            }
            return result;
        }
        public void PrintName(ref string Name)
        {
            Console.WriteLine(Name);
            Name = "Mahesh";
        }
        public void OutPrintName(out string Name)
        {
            Name = string.Empty;
        }
    }
}
