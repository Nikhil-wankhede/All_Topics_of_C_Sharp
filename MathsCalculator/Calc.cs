using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsCalculator
{
    public class Calc
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        protected internal int Division(int a, int b)
        {
            return a / b;
        }
        protected int Test(int a, int b)
        {
            return a / b;
        }
        private protected int GetTotal(int a, int b)
        {
            return a - b;
        }
    }
}
