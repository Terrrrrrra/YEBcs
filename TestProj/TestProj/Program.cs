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

            //List<int> intList = new List<int>();
            Cat();

            // Car 는 클래스
            // 클래스 뒤에 ()는 생성자
            // new Car() 는 Car 타입 객체를 새로 생성한다는 의미

            Car mycar = new Car();

            // double = 8바이트, float = 4바이트
            // double -> float 바로 전환 안됨, 숫자뒤에 f 붙여주기

            mycar.PrintInfo();

            mycar.Tire = 4;
            mycar.Speed = 50.3f;
            mycar.Cost = 10_000_000.5;
            mycar.Name = "기아자동차";

            mycar.PrintInfo();
            //print(mycar.Tire);
            //print(mycar.Speed);
            //print(mycar.Cost);
            //print(mycar.Name);
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
