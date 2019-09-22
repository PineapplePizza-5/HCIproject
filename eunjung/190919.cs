/* ************************************************
 * 프로그램명 : 클래스_실습1.cs 
 * 작성자 : 2018038044 최은정
 * 작성일 : 2019.09.19
 * 프로그램설명 : 실습 1_수식계산프로그램
 * ************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            int FirstNum;
            int SecondNum;
            string operatorr;
            int result = 0;

            Console.Write("첫 번째 숫자를 입력하세요        : ");
            FirstNum = int.Parse(Console.ReadLine());

            Console.Write("연산자를 입력하세요 (+, -, *, /) : ");
            operatorr = Console.ReadLine();

            Console.Write("두 번째 숫자를 입력하세요        : ");
            SecondNum = int.Parse(Console.ReadLine());

            //switch문
            switch (operatorr)
            {
                case "+":
                    result = FirstNum + SecondNum;
                    break;

                case "-":
                    result = FirstNum - SecondNum;
                    break;

                case "*":
                    result = FirstNum * SecondNum;
                    break;

                case "/":
                    result = FirstNum / SecondNum;
                    break;

                default:
                    break;
            }

            Console.WriteLine("연산 결과는 다음과 같습니다      : {0} {1} {2} = {3}\n", FirstNum, operatorr, SecondNum, result);

        }
    }
}


/* ************************************************
 * 프로그램명 : HelloWorld.cs 
 * 작성자 : 2018038044 최은정
 * 작성일 : 2019.09.19
 * 프로그램설명 : 실습 1_수식계산프로그램
 * ************************************************/

// namespace ConsoleApp1 {
//     class Program {
//         static void Main(string[] args) {
//             int FirstNum;
//             int SecondNum;
//             string operatorr;
//             int result = 0;

//             Console.Write("첫 번째 숫자를 입력하세요        : ");
//             FirstNum = int.Parse(Console.ReadLine());

//             Console.Write("연산자를 입력하세요 (+, -, *, /) : ");
//             operatorr = Console.ReadLine();

//             Console.Write("두 번째 숫자를 입력하세요        : ");
//             SecondNum = int.Parse(Console.ReadLine());

//             //switch문
//             switch (operatorr)
//             {
//                 case "+":
//                     result = FirstNum + SecondNum;
//                     break;

//                 case "-":
//                     result = FirstNum - SecondNum;
//                     break;

//                 case "*":
//                     result = FirstNum * SecondNum;
//                     break;

//                 case "/":
//                     result = FirstNum / SecondNum;
//                     break;
//             }

//             Console.WriteLine("연산 결과는 다음과 같습니다      : {0} {1} {2} = {3}\n", FirstNum, operatorr, SecondNum, result);

//         }
//     }
// }