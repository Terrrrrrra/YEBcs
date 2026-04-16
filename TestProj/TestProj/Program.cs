using System;
using TestProj.Inheritance2;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster mon1 = new Goblin(20, 4, "우가우가");
            Monster mon2 = new Skeleton(30, 3, "샌즈");

            for (int i = 0; i < 7; i++)
            {
                mon1.Attack(mon2);
                mon2.Attack(mon1);
            }
        }










        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
