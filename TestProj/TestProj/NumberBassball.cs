using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    internal class NumberBassball
    {
        // 이 메소드를 호출하면 게임시작
        internal void Run()
        {
            /*string numStr = "273";
            int num1 = numStr[0] - '0';
            int num2 = numStr[1] - '0';
            int num3 = numStr[2] - '0';

            print(num1);
            print(num2);
            print(num3);*/

            int[] selectNumArr = MakeSelectNumArr();

            Console.WriteLine($"시스템이 생성한 값 : {selectNumArr[0]}{selectNumArr[1]}{selectNumArr[2]}");

            while (true)
            {
                Console.Write("숫자를 입력하세요 : ");
                string input = Console.ReadLine();

                try
                {
                    int inputNum = int.Parse(input);
                }
                catch (FormatException e)
                {
                    print("숫자로 입력해주세요!");
                    continue;
                }

                if(input.Length != 3)
                {
                    print("3자리로 입력해주세요!");
                    continue;
                }

                int num1 = input[0] - '0';
                int num2 = input[1] - '0';
                int num3 = input[2] - '0';
                // TODO: 입력받은 값이 중복됐는지 검사할것
                if (num1 == num2 || num2 == num3 || num3 == num1)
                {
                    print("중복된 숫자가 존재합니다, 다시 입력해 주세요");
                    continue;
                }

                int strike = 0;
                int ball = 0;

                // 내가 입력한 첫번째자리수부터 검사
                // 시스템이 뽑은 첫번째자리와 내가 입력한 값의 첫번째자리가 같으면 strike++
                if (selectNumArr[0] == num1)
                {
                    //strike = strike + 1;
                    //strike += 1;
                    strike++;
                }
                // 스트라이크가 아니라면 볼 인지 체크해서 볼 이면 ball++
                // (앰퍼샌드)   && -> and : 양쪽이 모두 true일때만 true, 하나라도 false면 false
                // (파이프라인) || -> or  : 양쪽중에 하나라도 true면 true, 둘다 false일때만 false
                else if (selectNumArr[1] == num1 || selectNumArr[2] == num1)
                {
                    ball++;
                }

                // 내가 입력한 두번째자리수 검사
                if (selectNumArr[1] == num2)
                {
                    strike++;
                }
                else if (selectNumArr[2] == num2 || selectNumArr[0] == num2)
                {
                    ball++;
                }

                // 내가 입력한 세번째자리수 검사
                if (selectNumArr[2] == num3)
                {
                    strike++;
                }
                else if (selectNumArr[1] == num3 || selectNumArr[2] == num3)
                {
                    ball++;
                }

                // 3스트라이크 시 승리~!
                if (strike >= 3)
                {
                    // 3스트라이크면 승리멘트 출력 후 종료
                    print("3스트라이크 승리");
                    break;
                }

                // 최종 결과를 사용자한테 보여준다
                // 예) 0스트라이크 0볼~!
                print($"{strike}스트라이크 {ball}볼~!");
            }

        }

        // 배열을 만드는 기능의 *캡슐화*
        // 캡슐화를 하면 코드의 가독성, 재사용성 증가 및 유지보수 용이
        int[] MakeSelectNumArr()
        {
            int[] result = new int[3];
            List<int> numPool = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rd = new Random();

            // cur : 현재, Pre : 과거, next : 미래
            int curIndex = rd.Next(0, numPool.Count); // numPool에서 랜덤한 숫자를 정하고 numPool.Count == 10
            result[0] = numPool[curIndex]; // numPool에서 정한 숫자를 넣음
            numPool.Remove(numPool[curIndex]); // numPool에서 정한 숫자를 지움

            curIndex = rd.Next(0, numPool.Count); // numPool.Count == 9
            result[1] = numPool[curIndex];
            numPool.Remove(numPool[curIndex]);

            curIndex = rd.Next(0, numPool.Count);
            result[2] = numPool[curIndex];

            return result;
        }

        void print(object obj)
        {
            // WriteLine 메소드가 스태틱 메소드이기떄문에 클래스이름을 통해 바로호출가능
            Console.WriteLine(obj.ToString());
        }

        static internal void Hello()
        {
            Console.WriteLine("안녕하세요");
        }
    }
}
