using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;

            Console.WriteLine($"저는 {num1}살 입니다.");


            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"그로부터 {i}년이 지났습니다..");
            }

            Console.Write("숫자를 입력하세요 : ");
            int inputNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"입력받은 숫자는 {inputNum}입니다.");
        }
    }
}
