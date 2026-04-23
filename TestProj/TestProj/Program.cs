using System;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Error2();
            }
            catch
            {
                print("에러발생, Main에서 처리");
            }
        }

        static void Error1()
        {
            throw new Exception();
        }

        static void Error2()
        {
            try
            {
                Error1();
            }
            catch
            {
                print("에러발생, Error2에서 처리");
            }
        }

        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
