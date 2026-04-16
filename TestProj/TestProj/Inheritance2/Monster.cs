using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj.Inheritance2
{
    internal abstract class Monster : IHit, IAttack
    {
        public readonly float Hp;
        public float CurHp;
        public float Damage;
        public string Name;

        public Monster(float hp, float damage, string name)
        {
            Hp = hp;
            CurHp = hp;
            Damage = damage;
            Name = name;
        }

        public abstract void Attack(Monster monster);

        public virtual void Cry() { }

        public abstract void Hit(float damage);
    }
}
