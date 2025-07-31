using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsCalculator;

namespace All_Topics_of_C_Sharp.OOPS
{
    internal class UseOfClassLibraryProjectOutput : Calc
    {
        public void InitializeClassLibraryOutput() 
        {
            Calc obj = new Calc();
            //int c = obj.Multiplication(10, 20);
            Division(10, 20);

            
        }
    }
}
