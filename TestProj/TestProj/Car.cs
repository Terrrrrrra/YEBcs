using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    internal class Car
    {
        // int, float, double  값 형, 생성시 자동으로 zero value로 초기화
        public int Tire;
        public float Speed;
        public double Cost;
        public string Name;

        // 함수구조 : 접근제한자 + 반환타입 + 함수이름
        public void PrintInfo()
        {
            Console.WriteLine($"타이어 개수 : {Tire}");
            Console.WriteLine($"속도 : {Speed}");
            Console.WriteLine($"가격 : {Cost}");
            Console.WriteLine($"이름 : {Name}");
        }

        // 생성자구조 : 접근제한자 + 클래스이름
        public Car(int tire, float speed, double cost, string name)
        {
            Tire = tire;
            Speed = speed;
            Cost = cost;
            Name = name;
        }
    }
}
