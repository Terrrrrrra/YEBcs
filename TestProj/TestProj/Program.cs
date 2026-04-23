using System;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            // dog.MoveTail();
            Animal animal1 = dog;

            NumberBassball.Hello();

            NumberBassball numberBassball = new NumberBassball();
            numberBassball.Run();
        }





        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
