using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Student
    {
        protected int korean;
        protected int english;
        protected int math;
        protected double average;

        //set만들기
        public void SetScore()
        {
            Console.Write("국어 성적 : ");
            this.korean = int.Parse(Console.ReadLine());
            Console.Write("수학 성적 : ");
            this.math = int.Parse(Console.ReadLine());
            Console.Write("영어 성적 : ");
            this.english = int.Parse(Console.ReadLine());

            Console.Write("\n");

        }

        //get만들기
        public double GetAverage()
        {
            average = (double)((this.korean + this.math + this.english) / 3);
            return this.average;
        }



    }

    class Program2
    {
        static void Main(string[] args)
        {
            Student[] sList;
            sList = new Student[3];         //sList를 가리킬 3개의 변수 생성

            for (int i = 0; i < 3; i++) 
            {
                sList[i] = new Student();
                Console.WriteLine("Student? {0}", i);
                sList[i].SetScore();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Average = {0:f2}", sList[i].GetAverage());

            }

        }
    }
}
