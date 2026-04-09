using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr1 = new int[2];
            intArr1[0] = 23;
            intArr1[1] = 34;

            int[] intArr2 = new int[] { 123, 234, 345 };

            List<int> intList1 = new List<int>();
            intList1.Add(23);
            intList1.Add(34);

            List<int> intList2 = new List<int>() { 123, 234, 345 };

            // ------------------------------------------------------------------
            // 씨샵의 딕셔너리 자료형
            // 딕셔너리의 특징 - 키,값 쌍
            Dictionary<int, string> myDict = new Dictionary<int, string>();

            myDict[2002] = "월드컵 4강간날";
            myDict[2020] = "코로나 창궐";
            myDict[1945] = "대한민국 독립일";

            print(myDict[2020]);
            print(myDict[2002]);
            //print(myDict[500]);

            print($"500번 키 있음? : {myDict.ContainsKey(500)}");
            print($"2002번 키 있음? : {myDict.ContainsKey(2002)}");

            int key = 2002;
            if (myDict.ContainsKey(key))
            {
                print(myDict[key]);
            }

            // ------------------------------------------------------------
            print("=================================================================");

            Dictionary<string, Pokemon> pokemonDict = new Dictionary<string, Pokemon>();

            pokemonDict["야도란"] = new Pokemon("야도란", 100, 100);
            pokemonDict["구구"] = new Pokemon("구구", 50, 50);
            pokemonDict["딥상어동"] = new Pokemon("딥상어동", 120, 110);

            pokemonDict["야도란"].Skill();

            print(pokemonDict["딥상어동"].Hp);

            print($"두리쥐 있나요? : {pokemonDict.ContainsKey("두리쥐")}");
            print($"구구 있나요? : {pokemonDict.ContainsKey("구구")}");
        }










        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
