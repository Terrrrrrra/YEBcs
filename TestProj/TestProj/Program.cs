using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 스태틱 메소드는 클래스 이름으로 바로 호출 가능
            print(Calculator.CalcSum(234, 120));

            // Calculator.CalcPow(4, 7); 스태틱 메소드가 아니라서 바로 호출 불가능
            // 객체생성후에 함수호출

            // 스태틱이 아닌 것들은 전부 다이나믹
            // 다이나믹 메소드는 객체 생성 후에 호출가능
            Calculator calcObj = new Calculator();
            print(calcObj.CalcPow(4, 7));
            // calcObj.CalcSum(40, 55);

            // 스태틱은 변수에도 붙을 수 있음
            print(Calculator.PI);
        }

        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
