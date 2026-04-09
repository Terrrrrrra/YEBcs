using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    // 부모클래스
    internal class Animal
    {
        public string Name;
        public int Leg;
        public string Sound;
        public string Info = "정보1번";
        private string Info2 = "사실 별거 없음~";
        protected string Info3 = "정보3번";

        public void PrintInfo()
        {
            // Animal에 있는 필드 사용가능
            Console.WriteLine($"{Name}(은)는 다리가 {Leg}개고 {Sound}하고 웁니다");
            // private은 같은 레벨, 위치에서 접근가능
            Console.WriteLine($"Info2 의 내용 : {Info2}");
            // protected은 같은 레벨, 위치에서 접근가능
            Console.WriteLine($"Info3 의 내용 : {Info3}");
        }
    }


}
