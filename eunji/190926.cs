using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade_3student
{

    class Student
    {
        public int kor;
        public int math;
        public int eng;
        public int ID;


        public Student(int student_ID) {
            ID = student_ID;
            Console.WriteLine(ID + "번 학생의 점수 입니다.");
        }

        public void setScore()
        {
            Console.Write("국어성적 : ");
            kor = int.Parse(Console.ReadLine());
            Console.Write("수학성적 : ");
            math = int.Parse(Console.ReadLine());
            Console.Write("영어성적 : ");
            eng = int.Parse(Console.ReadLine());
        }
        }

    class Average
    {
        public int kor_sum = 0;
        public int math_sum = 0;
        public int eng_sum = 0;

        public int kor_average;
        public int math_average;
        public int eng_average;


        public void getAverage(Student[] student)
        {

            for (int i = 0; i < 3; i++)
            {
                kor_sum += (student[i].kor);
                math_sum += (student[i].math);
                eng_sum += (student[i].eng);
            }

            kor_average = kor_sum / 3;
            math_average = math_sum / 3;
            eng_average = eng_sum / 3;

            Console.Write("국어 과목의 평균은 : = {0} ", kor_average);
            Console.Write("수학 과목의 평균은 : = {0} ", math_average);
            Console.Write("영어 과목의 평균은 : = {0} ", eng_average);

            Console.ReadLine();
        }

    }

        class Program
        {
            static void Main(string[] args)
            {
            Student[] student;
            Average score = new Average();
            student = new Student[3];
            for (int i = 0; i < 3; i++) {
                student[i] = new Student(i+1);
                student[i].setScore();
            }
            score.getAverage(student);

            }
        }


    }
