using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* **********************************************
* 프로그래명 : HCI_practice.cs
• 작성자 : 2018038056 신ㅇ느지
• 작성일 : 2019.09.19
*프로그램 설명 : 계산기
************************************************/

// namespace HCI_practice0919
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int op1;
//             int op2;
//             int result = 0;
//             string d;
//             Console.Write("첫 번째 숫자를 입력하세요 : ");
//             op1 = int.Parse(Console.ReadLine());  // 엔터까지 문자로 치기때문에 라인으로 받아야함
//             Console.Write("연산자를 입력하세요 (+, -, *,/) : ");
//             d = Console.ReadLine();
//             Console.Write("두 번째 숫자를 입력하세요 : ");
//             op2 = int.Parse(Console.ReadLine());

//             switch (d) {
//                 case "+":
//                     result = op1 + op2;
//                     break;
//                 case "-":
//                     result = op1 - op2;
//                     break;
//                 case "*":
//                     result = op1 * op2;
//                     break;
//                 case "/":
//                     result = op1 / op2;
//                     break;
//             }

//             Console.WriteLine("{0} {1} {2} = {3}", op1, d, op2, result);
//             Console.ReadKey(); // 콘솔창 유지하기 위해 넣음
//         }
//     }
// }



////// 성적 평균

namespace grade_program {
    class Student {
        public int kor;
        public int math;
        public int eng;
        public int average;

        public void setScore() {
            Console.Write("국어성적 : ");
            kor = int.Parse(Console.ReadLine());
            Console.Write("수학성적 : ");
            math = int.Parse(Console.ReadLine());
            Console.Write("영어성적 : ");
            eng = int.Parse(Console.ReadLine());
        }

        public void getAverage() {
            average = (kor + math + eng) / 3;
            Console.Write("과목의 평균은 : = {0} ", average);
            Console.ReadLine();
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Student A = new Student();
            A.setScore();
            A.getAverage();
        }
    }
}