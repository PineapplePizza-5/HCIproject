/* *******************************
 * 프로그램명 : Swap.cs
 * 작성자 : 2018038017 이송이
 * 작성일 : 2019.09.26
 * 프로그램 설명 : 실습과제 1 <swap만들기>           // 15~37
 * 프로그램 설명 : 실습과제 2 <3명의 평균 구하기>    // 39~80
 * *******************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace HCI_Project
//{
//    class Program {
//        public void swap(ref int a,ref int b)
//        {
//            int temp;
//            temp = a;
//            a = b;
//            b = temp;

//        }
//        static void Main(string[] args)
//        {
//            int x = 10;
//            int y = 20;
//            Console.WriteLine("X = {0}, Y = {1}", x, y);

//            Program app = new Program();
//            app.swap(ref x, ref y);
//            Console.WriteLine("X = {0}, Y = {1}", x, y);
//        }
//    }
//}

namespace HCI_Progject
{
    class Student                                   // 조건 Student 클래스를 만들어 개발하시오
    {
        private float kor = 0, math = 0, eng = 0;   // 조건 Attribute (variable) : kor, math, eng
        public void setScore()                      // 조건 Method : setScore(), getAverage()
        {

            Console.Write("Korean? ");
            kor = float.Parse(Console.ReadLine());  // 문자열을 받아와 실수형으로 Parse한다
            Console.Write("Math? ");
            math = float.Parse(Console.ReadLine());
            Console.Write("Eng? ");
            eng = float.Parse(Console.ReadLine());
        }
        public void getAverage()
        {
            float result = (kor + math + eng) / 3;
            Console.WriteLine("Average = {0:f2}", result);    // :f2는 소수점 둘째자리까지 나타내기 위함
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Student[] stu = new Student[3];
            stu[0] = new Student();
            stu[1] = new Student();
            stu[2] = new Student();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Student? {0}", i);
                stu[i].setScore();
            }
            for (int i = 0; i < 3; i++)
            {
                stu[i].getAverage();
            }
        }
    }
}
