/* ************************************************
 * 프로그램명 : 클래스_실습2.cs
 * 작성자 : 2018038044 최은정
 * 작성일 : 2019.09.19
 * 프로그램설명 : 실습 2_성적계산 프로그램
 * ************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1{
    class Student{
        private int kor;
        private int math;
        private int eng;
        private double average;

        public void SetScore()
        {
            Console.Write("국어 성적 : ");
            this.kor = int.Parse(Console.ReadLine());
            Console.Write("수학 성적 : ");
            this.math = int.Parse(Console.ReadLine());
            Console.Write("영어 성적 : ");
            this.eng = int.Parse(Console.ReadLine());

        }
        public double GetAverage()
        {
            average = (double)((this.kor + this.math + this.eng) / 3);
            return this.average;
        }
    }

    class Program {
        static void Main(string[] args) {
            Student jeong = new Student();  //jeong 학생 객체 생성
            
            jeong.SetScore();
            
            Console.WriteLine("과목 평균 : {0:f2}\n", jeong.GetAverage());

        }
    }
}
