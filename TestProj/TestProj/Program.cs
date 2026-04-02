using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===구구단을 외자===");
            Console.Write("구구단 몇단? : ");
            int input = int.Parse(Console.ReadLine());

            /*
            구구단 몇단? : 2
            2 * 1 = 2
            2 * 2 = 4
            2 * 3 = 6
            2 * 4 = 8
            2 * 5 = 10
            2 * 6 = 12
            2 * 7 = 14
            2 * 8 = 16
            2 * 9 = 18
            */
            // 선언식, 조건식, 증감식
            // 선언식에선? int i = 1
            // 조건식에선? i < 10, i <= 9
            // 증감식에선? i++
            for(int i = 1; i < 10; i++)
            {
                // 코드부분에선?
                Console.WriteLine($"{input} * {i} = {input*i}");
            }



            Console.WriteLine("프로그램 종료");
        }
    }
}
