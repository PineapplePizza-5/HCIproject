/* *************************************
 * 프로그램명 : calculator.cs
 * 작성자 : 2018038017 이송이
 * 작성일 : 2019.09.19
 * 프로그램 설명 : 실습과제 1 <계산기>       // 12~33
 * 프로그램 설명 : 실습과제 2 <평균 구하기>  // 35~64
 * **************************************/

using System;
using System.Text;

//namespace Calculator {
//    class Calculate
//    {
//        static void Main(string[] args)
//        {
//            int num1, num2, result = 0;
//            string op;
//            Console.Write("첫번째 숫자를 입력하세요 : ");
//            num1 = int.Parse(Console.ReadLine());
//            Console.Write("연산자를 입력하세요 (+,-,*,/) : ");
//            op = Console.ReadLine();
//            Console.Write("두번째 숫자를 입력하세요 : ");
//            num2 = int.Parse(Console.ReadLine());
//            if (op == "+") result = num1 + num2;
//            else if (op == "-") result = num1 - num2;
//            else if (op == "*") result = num1 * num2;
//            else if (op == "/") result = num1 / num2;
//            else { Console.WriteLine("정의되지 않은 연산자입니다."); return; }    // 정의되지 않은 연산자가 입력되면 오류 메시지 출력 후 종료
//            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, result);
//        }
//    }
//}

namespace Everage
{
    class Student                                   // 조건 Student 클래스를 만들어 개발하시오
    {
        private float kor = 0, math = 0, eng = 0;   // 조건 Attribute (variable) : kor, math, eng
        public void setScore()                      // 조건 Method : setScore(), getAverage()
        {
            Console.Write("국어성적 : ");
            kor = float.Parse(Console.ReadLine());  // 문자열을 받아와 실수형으로 Parse한다
            Console.Write("수학성적 : ");
            math = float.Parse(Console.ReadLine());
            Console.Write("영어성적 : ");
            eng = float.Parse(Console.ReadLine());
        }
        public void getAverage()
        {
            float result = (kor + math + eng) / 3;
            Console.WriteLine("과목의 평균은 : = {0:f2}", result);    // :f2는 소수점 둘째자리까지 나타내기 위함
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.setScore();
            stu.getAverage();
        }
    }
}

// changes.