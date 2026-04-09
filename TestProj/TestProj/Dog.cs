using System;

namespace TestProj
{
    // 자식클래스, Animal 클래스를 "상속"받았음
    internal class Dog : Animal
    {
        public Dog(string name, int leg, string sound)
        {
            Name = name;
            Leg = leg;
            Sound = sound;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Info);
            // private은 같은레벨이 아니면 접근불가
            // Console.WriteLine(Info2);
            // protected은 상속받은 자식클래스에서 접근가능
            Console.WriteLine(Info3);
        }
    }
}
