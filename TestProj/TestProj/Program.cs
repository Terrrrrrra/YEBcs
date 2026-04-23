using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.name = "치와와";

            Zoo<int> zoo = new Zoo<int>();
            zoo.SetAnimal(45);
            print(zoo.curAnimal);

            Zoo<Dog> zoo2 = new Zoo<Dog>();
            zoo2.SetAnimal(dog);
            zoo2.curAnimal.Walk();

            List<int> intList = new List<int>();
            intList.Add(0);
            intList.Add(35);
            print(intList[1]);
            print(intList[0]);
            print(intList.Count);

            List<string> strList = new List<string>();
            strList.Add("인천");
            strList.Add("서울");
            strList.Add("부산");

            print(strList[2]);
            print(strList[0]);
            print(strList.Count);

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict[2002] = "월드컵4강";
            dict[2014] = "아시안 게임";

            //print(dict[2002]);
            if(dict.TryGetValue(123, out string value))
            {
                print(value);
            }

            print(dict.Count);

            if(int.TryParse("123", out int num))
            {
                print(num + 100);
            }

            print("==========");
            Console.WriteLine(dog);
        }





        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
