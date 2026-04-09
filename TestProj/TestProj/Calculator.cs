using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    internal class Calculator
    {
        public static double PI = 3.14;

        public static float CalcSum(float num1, float num2)
        {
            return num1 + num2;
        }

        public float CalcPow(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
