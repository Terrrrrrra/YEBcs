using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    // 이름, 체력, 스피드, 기술
    internal class Pokemon
    {
        // 클래스 내에 존재하는 변수들 == 필드
        public string Name;
        public int Hp;
        public float Speed;

        public void Skill()
        {
            Console.WriteLine($"{Name}(이)가 몸통박치기를 시전했다...!");
            Console.WriteLine($"현재체력 : {Name} | 현재 스피드 : {Speed}");
        }

        public Pokemon(string name, int hp, float speed)
        {
            Name = name;
            Hp = hp;
            Speed = speed;
        }
    }
}
