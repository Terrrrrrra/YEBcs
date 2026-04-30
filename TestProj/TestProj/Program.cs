using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bottle bottle = new Bottle();
            bottle.Max = 1000;

        
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


        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
