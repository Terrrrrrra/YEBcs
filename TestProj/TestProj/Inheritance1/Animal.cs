using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    internal class Animal
    {
        public string name;
        public int leg;

        public virtual void PrintLeg()
        {
            Console.WriteLine($"이 동물은 {leg}개의 다리를 가지고 있습니다");
        }

        public void Howling()
        {
            Console.WriteLine($"{name}가 울부짖는다");
        }

        // 메소드 오버로딩
        // 같은 함수 이름이더라도 매개변수의 종류가 다르면 다른 함수이다
        public void Howling(int roop)
        {
            for(int i = 0; i < roop; i++)
            {
                Console.WriteLine($"{name}가 울부짖는다 {i + 1}번 반복");
            }
        }
    }
}
