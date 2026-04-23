using System;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 0, 1, 2, 3 };
            Console.Write("정수 입력 : ");
            string input = Console.ReadLine();
            int inputNum = -1;
            int curNum = -1;

            try
            {
                inputNum = int.Parse(input);
                curNum = intArr[4];
            }
            catch (FormatException ex)
            {
                print("정수로 입력하세요!");
            }
            catch (IndexOutOfRangeException ex)
            {
                print("인덱스 범위 벗어남!");
            }
            catch (Exception ex)
            {
                print(ex.Message);
            }

            print(inputNum);
            print(curNum);


            Console.Write("정수 입력 : ");
            string input2 = Console.ReadLine();
            TryParse(input2, out int inputNum2);
            print($"입력한 정수 : {inputNum2}");
        }

        static void TryParse(string s, out int num)
        {
            try
            {
                num = int.Parse(s);
                print("변환 성공!");
            }
            catch
            {
                num = 0;
                print("변환 실패...");
            }
        }


        static void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }
    }
}
