using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Run()이 스태틱이 아닐때 사용하는법
            NumberBassball nb = new NumberBassball();
            nb.Run();

            //Run()이 스태틱일때 사용하는법
            //NumberBassball.Run();
        }










        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
