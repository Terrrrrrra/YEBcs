using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestProj.Inheritance2
{
    internal class Goblin : Monster
    {
        public Goblin(float hp, float damage, string name) : base(hp, damage, name)
        {

        }

        public override void Attack(Monster monster)
        {
            Console.WriteLine($"고블린의 공격!");
            monster.Hit(Damage);
        }

        public override void Cry()
        {
            Console.WriteLine("고블린이 울부짖는다...");
        }

        public override void Hit(float damage)
        {
            CurHp -= damage;
            Console.WriteLine($"고블린이 {damage}만큼 데미지 입음");
            Console.WriteLine($"{Name}의 체력 {CurHp}/{Hp}");
            if(CurHp <= 0)
            {
                Console.WriteLine($"{Name}사망!!");
            }
        }


    }
}
