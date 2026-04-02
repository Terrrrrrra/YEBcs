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

        public void PrintInfo()
        {
            Console.WriteLine($"타이어 개수 : {Tire}");
            Console.WriteLine($"속도 : {Speed}");
            Console.WriteLine($"가격 : {Cost}");
            Console.WriteLine($"이름 : {Name}");
        }
    }
}
