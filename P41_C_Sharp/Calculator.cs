using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{


    public delegate int CalcDelegate(int a, int b);

    public class Calculator
    {

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Diff(int a, int b)
        {
            return a - b;
        }

        public static int Mult(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}
