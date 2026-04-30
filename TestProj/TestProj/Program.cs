using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelePrac delePrac = new DelePrac();
            delePrac.Init();
            //delePrac.Func1 = Calc3;
            //delePrac.Func1?.Invoke(6, 8);
            delePrac.Init();
            delePrac.Func1 += Calc3;
            delePrac.Run();
            delePrac.Remove();
            delePrac.Run();

            Bottle bottle = new Bottle();
            bottle.Max = 1000;
            bottle.WaterEvent += WaterEvent;

            bottle.Water += 100;
            bottle.Water += 200;
            bottle.Water -= 150;
            bottle.Water -= 250;
            bottle.Water -= 250;
            bottle.Water -= 250;
            bottle.Water -= 250;

            bottle.Water += 700;
            bottle.Water += 700;
        }

        static void WaterEvent(float water)
        {
            print($"현재 물의 양{water}");
        }

        static void Calc3(int a, int b)
        {
            print(a + a + b);
        }

        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
