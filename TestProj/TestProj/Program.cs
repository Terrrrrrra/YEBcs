using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello world";

            print(hello[3]);
            print(hello[5]);
            print(hello[6]);
            print("==============================");
            string numStr = "273";
            char ch1 = numStr[0];
            print(ch1); // 문자 2가 출력됨
            int num1 = ch1;
            print(num1); // 문자 2에 해당하는 비트값이 정수로 변환되어 출력됨 (50)

            /*
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
            selectNumArr[2] = numPool[curIndex];

            Console.WriteLine(selectNumArr[0]);
            Console.WriteLine(selectNumArr[1]);
            Console.WriteLine(selectNumArr[2]);

            Console.Write("숫자를 입력하세요 : ");*/
        }










        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
