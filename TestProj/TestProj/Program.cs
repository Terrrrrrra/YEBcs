using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 클래스 == 설계도
            // 객체 == 설계도를 통해 실제 존재하는것을 만든것

            // Car 는 클래스
            // 클래스 뒤에 ()는 생성자
            // new Car() 는 Car 타입 객체를 새로 생성한다는 의미

            Car mycar = new Car(6, 32.4f, 2000_0000, "현대자동차");

            mycar.PrintInfo();

            /*mycar.Tire = 4;
            mycar.Speed = 50.3f;
            mycar.Cost = 10_000_000.5;
            mycar.Name = "기아자동차";*/

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
