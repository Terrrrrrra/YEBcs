using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> strStack = new Stack<string>();
            strStack.Push("보라돌이");
            strStack.Push("뚜비");
            strStack.Push("나나");
            strStack.Push("뽀");
            print(strStack.Count);

            print(strStack.Pop()); // 맨 위에있는걸 꺼냄
            print(strStack.Count);
            print(strStack.Peek()); // 맨 위에있는걸 확인함
            print(strStack.Count);

            print("\n================================\n");

            Queue<string> strQueue = new Queue<string>();
            strQueue.Enqueue("보라돌이");
            strQueue.Enqueue("뚜비");
            strQueue.Enqueue("나나");
            strQueue.Enqueue("뽀");

            print(strQueue.Count);
            print(strQueue.Dequeue());
            print(strQueue.Count);
            print(strQueue.Peek());
            print(strQueue.Count);
        }


        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
