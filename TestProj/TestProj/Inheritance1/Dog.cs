using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    internal class Dog : Animal, IWalk, IRun
    {
        // 메소드(함수) 오버라이딩
        public override void PrintLeg()
        {
            Console.WriteLine($"이 개는 {leg}개의 다리를 가지고 있습니다");
        }

        public void MoveTail()
        {
            Console.WriteLine("강아지 꼬리 살랑살랑");
        }

        public void Walk()
        {
            Console.WriteLine("강아지가 걸어간다..");
        }

        public void Run()
        {
            Console.WriteLine("강아지가 뛴다!!");
        }

        public override string ToString()
        {
            return $"{name}를 출력합니다";
        }
    }
}
