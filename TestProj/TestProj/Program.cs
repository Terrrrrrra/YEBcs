using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Calc1(7);
            print(num1);

            int num2 = Calc1(4);
            print(num2);

            int num3 = Calc2(24, 13);
            print(num3);
        }

        static int Calc2(int a, int b)
        {
            return a + b;
        }

        static int Calc1(int a)
        {
            int b = a + a;
            return b;
        }

        static int GetNumber()
        {
            int a = 12;
            int b = 25;
            int c = a + b;
            return c;
        }


        static void Dog()
        {
            print("강아지는....");
            return;
            print("멍멍!");
        }


        static void Cat()
        {
            print("고양이는 야옹야옹");
        }



































        static void print(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
