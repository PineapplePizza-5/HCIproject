using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 계산기

namespace practice_week3_01
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int operand1,operand2, result;
            string Operator;
    
            Console.WriteLine("첫번째 숫자를 입력하세요 : ");
            operand1 = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자를 입력하세요 (+,-,*,/) : ");
            Operator = Console.ReadLine();
            Console.WriteLine("두번째 숫자를 입력하세요 : ");
            operand2 = int.Parse(Console.ReadLine());
            switch (Operator)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine("{0} + {1} = {2}", operand1, operand2, result);
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine("{0} - {1} = {2}", operand1, operand2, result);
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine("{0} * {1} = {2}", operand1, operand2, result);
                    break;
                case "/":
                    result = operand1 / operand2;
                    Console.WriteLine("{0} / {1} = {2}", operand1, operand2, result);
                    break;
                default:
                    Console.WriteLine("사칙연산자를 잘못 입력하였습니다.");
                    break;
            }
        }
    }
}


/// 성적 평균 

// namespace practice_week3_02
// {
//     class Student
//     {
//         public int kor;
//         public int math;
//         public int eng;

//         public void setScore() {
//             Console.WriteLine("국어성적 : ");
//             kor = int.Parse(Console.ReadLine());
//             Console.WriteLine("수학성적 : ");
//             math = int.Parse(Console.ReadLine());
//             Console.WriteLine("영어성적 : ");
//             eng = int.Parse(Console.ReadLine());
//         }
//         public void getAverage()
//         {
//             int average;
//             average = (kor + math + eng) / 3;
//             Console.WriteLine("과목의 평균은 = {0}", average);
//         }
//     }
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             Student stu1 = new Student();
//             stu1.setScore();
//             stu1.getAverage();
//         }
//     }
// }
