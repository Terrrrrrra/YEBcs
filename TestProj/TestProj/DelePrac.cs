using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    internal class DelePrac
    {
        internal event Action<int, int> Func1;

        internal void Init()
        {
            Func1 = null;
            Func1 += Calc1;
            Func1 += Calc2;
        }

        internal void Run()
        {
            int a = 2;
            int b = 4;
            Func1?.Invoke(a, b);
        }

        internal void Remove()
        {
            Func1 -= Calc1;
            Func1 -= Calc2;
        }

        void Calc1(int a, int b)
        {
            print(a + b);
        }

        void Calc2(int a, int b)
        {
            print(a * b);
        }

        static void print(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
