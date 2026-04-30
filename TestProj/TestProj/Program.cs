using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 지금껏 사용해본 자료형들 : 배열, 리스트, 딕셔너리
            // 배열 : 길이가 안늘어남, 인덱스로 접근 가능, 요소간 순서가 O
            int[] intArr = new int[] { 0, 1, 2 };

            // 리스트 : 길이가 가변적임 (늘이거나 줄이는게 가능), 인덱스로 접근 가능, 요소간 순서가 O
            List<string> strList = new List<string>();
            strList.Add("보라돌이");
            strList.Add("뚜비");
            strList.Add("뚜비");
            strList.Add("뚜비");
            strList.Add("나나");
            strList.Add("나나");
            print($"intList의 길이 : {strList.Count}");

            // intList 안의 내용물을 전부 print
            for (int i = 0; i < strList.Count; i++)
            {
                print(strList[i]);
            }

            print("\n리스트를 foreach로 순회");
            foreach (string item in strList)
            {
                print(item);
            }

            // 리스트 검색 시간 최악의 경우 리스트를 전부 순회함
            if (strList.Contains("나나")) { print("나나있음"); }
            else { print("나나없음"); }

            if (strList.Contains("뽀")) { print("뽀있음"); }
            else { print("뽀없음"); }

            // 딕셔너리 : 길이가 가변적임, 키로 접근가능, 요소간 순서가 X
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict[19] = "철수";
            dict[21] = "영희";
            print(dict[19]);

            // Set : 길이가 가변적임, 요소간 순서가 X (인덱스로 접근이 불가), 값으로서 접근가능
            // 특징 : 데이터의 중복을 허용하지 않음
            HashSet<string> strSet = new HashSet<string>();
            strSet.Add("보라돌이");
            strSet.Add("뚜비");
            strSet.Add("뚜비");
            strSet.Add("뚜비");
            strSet.Add("나나");
            strSet.Add("나나");

            print("\nHashSet을 foreach로 순회");
            foreach (string item in strSet)
            {
                print(item);
            }

            // HashSet 검색 시간 매우빠름 (해싱한 주소에 값 저장)
            if (strSet.Contains("나나")) { print("나나있음"); }
            else { print("나나없음"); }

            if (strSet.Contains("뽀")) { print("뽀있음"); }
            else { print("뽀없음"); }

            if (strSet.Contains("뚜비")) { print("뚜비있음"); }
            else { print("뚜비없음"); }
        }


        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
