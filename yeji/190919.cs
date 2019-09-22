//*프로그램명 : Calculator.cs
//    작성자 : 2018038060 홍예지
//    작성일 : 2019.9.19
//*프로그램 설명 : 계산기 프로그램

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace ConsoleApp1
// {
//     class Calculator
//     {
//         static void Main(string[] args)
//         {
//             int op1, op2, result;
//             string op;
//             Console.WriteLine("첫번째 숫자를 입력하세요 : ");
//             op1 = int.Parse(Console.ReadLine());
//             Console.WriteLine("연산자를 입력하세요 (+,-,*,/) : ");
//             op = Console.ReadLine();
//             Console.WriteLine("두번째 숫자를 입력하세요 : ");
//             op2 = int.Parse(Console.ReadLine());

//             if (op == "+") result = op1 + op2;
//             else if (op == "-") result = op1 - op2;
//             else if (op == "*") result = op1 * op2;
//             else if (op == "/") result = op1 / op2;
//             else { Console.WriteLine("잘못된 입력입니다.\n"); result = 0; }
//             Console.WriteLine(op1+" "+op+" "+op2+" = "+result);
//         }
//     }
// }


/*
 * 프로그램명 : Results.cs
 * 작성자 : 2018038060 홍예지
 * 작성일 : 2019.09.19
 * 프로그램 설명 : 성적계산 프로그램
*/

namespace Results
{
    class Student
    {
        public int kor, math, eng;
        public void setScore() {
            Console.WriteLine("국어성적 : ");
            kor = int.Parse(Console.ReadLine());
            Console.WriteLine("수학성적 : ");
            math = int.Parse(Console.ReadLine());
            Console.WriteLine("영어성적 : ");
            eng = int.Parse(Console.ReadLine());
        }
        public float getAverage() {
            return (float)(kor + math + eng) / 3;
        }
    }
    class Results
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.setScore();
            
            Console.WriteLine("과목의 평균은 : {0:f2}",std.getAverage());
            
        }
    }
}
