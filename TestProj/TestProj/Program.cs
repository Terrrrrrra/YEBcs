using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal am1 = new Dog();
            am1.name = "진돗개";
            am1.leg = 4;

            Animal am2 = new Bird();
            am2.name = "참새";
            am2.leg = 2;

            Dog dog = new Dog();
            dog.Walk();
            dog.Run();

            IWalk walkAm = new Dog();
            walkAm.Walk();

            am1.PrintLeg();
            am2.PrintLeg();
            dog.MoveTail();

            ((Dog)am1).MoveTail();
            //((Dog)am2).MoveTail();

            Dog dog2 = am1 as Dog;
            Dog dog3 = am2 as Dog;

            print($"dog2는 비어있나요? -> {dog2 == null}");
            print($"dog3는 비어있나요? -> {dog3 == null}");

            Animal am3 = new Pomeranian();
            am3.name = "왈왈이";

            Dog dog4 = (Dog)am3;
            //dog4.PrintInfo(); // Dog에는 PrintInfo가 없음
            Pomeranian pome = dog4 as Pomeranian;

            pome.PrintInfo(); // Pomeranian에 PrintInfo가 있음
            Pomeranian pome2 = (Pomeranian)am3;
            pome2.Walk();
            pome2.Run();

            /*Dog dog2 = (Dog)am1;
            dog2.MoveTail();*/

        }










        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
