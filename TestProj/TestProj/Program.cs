using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numPool = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Random rd = new Random();
            int[] selectNumArr = new int[3];
            // cur : 현재, Pre : 과거, next : 미래
            int curIndex = rd.Next(0, numPool.Count); // numPool에서 랜덤한 숫자를 정하고 numPool.Count == 10
            selectNumArr[0] = numPool[curIndex]; // numPool에서 정한 숫자를 넣음
            numPool.Remove(numPool[curIndex]); // numPool에서 정한 숫자를 지움

            curIndex = rd.Next(0, numPool.Count); // numPool.Count == 9
            selectNumArr[1] = numPool[curIndex];
            numPool.Remove(numPool[curIndex]);

            curIndex = rd.Next(0, numPool.Count);
            selectNumArr[2] = rd.Next(0, 10);

            Console.WriteLine(selectNumArr[0]);
            Console.WriteLine(selectNumArr[1]);
            Console.WriteLine(selectNumArr[2]);

            Console.Write("숫자를 입력하세요 : ");
            string input = Console.ReadLine();
        }










        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
