using System;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 값 타입, 참초 타입
            // 값 타입 : 변수 자체에 값이 들어가 있는 형태
            // 참조 타입 : 변수엔 객체의 주소가 들어가있는 형태
            int num1 = 5;
            print($"함수 호출전 : {num1}");
            Sum(ref num1);
            print($"함수 호출후 : {num1}");

            int num2;
            // print($"num2 함수 호출전 : {num2}");
            GetNum(out num2);
            print($"num2 함수 호출후 : {num2}");

            GetNum(out int num3);
            print($"num3 함수 호출후 : {num3}");

            Console.Write("정수 입력 : ");
            string input = Console.ReadLine();
            // int inputNum = int.Parse(input);
            int.TryParse(input, out int inputNum);
            print($"입력받은 숫자 : {inputNum}");
        }


        // ref를 통해 매개변수를 넘겨주면 원본을 보내준다
        static void Sum(ref int num1)
        {
            num1 += 100;
        }

        // 값 타입 변수는 매개변수로 넘길 때 복사되어서 넘어간다
        static void Sum2(int num1)
        {
            num1 += 100;
        }

        // out 키워드는 초기화되지 않은 변수를 초기화시켜서 내보낸다
        static void GetNum(out int num)
        {
            num = 35;
        }




        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
