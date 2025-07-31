using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsCalculator
{
    internal class Class1 : Calc
    {
        public void Test()
        {
            Calc obj = new Calc();
            obj.Division(10, 20);

            GetTotal(10, 20);

        }
    }
}
