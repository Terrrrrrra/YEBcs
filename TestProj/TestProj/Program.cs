using System;
using System.Collections.Generic;
using TestProj2;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("허스키", 4, "멍멍");

            Chicken chicken = new Chicken("토종닭", 2, "꼬끼오");

            dog.PrintInfo();
            chicken.PrintInfo();

            // public 은 언제 어디서나 접근가능
            string dogInfo = dog.Info;
            dog.ShowInfo();
            // private 은 외부에서 접근불가
            // string dogInfo2 = dog.Info2;
            // protected 은 외부에서 접근불가
            // dog.Info3

            InternalTest internalTest = new InternalTest();
            Console.WriteLine(internalTest.Info4);
        }










        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
