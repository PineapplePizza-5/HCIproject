using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_GradeManagementProgram
{
    class Student
    {
        String num, name; // num: 학번 , name: 이름
        int kor, eng, math, cs; // 각 과목별 점수
        int total, rank; // total: 총점, rank: 등수
        float evg; // evg: 평균(소숫점 한자리까지만 출력)
        char grade; // grade: 학점
        void init() // 학생 정보(학번, 이름, 각 과목별 점수)를 입력받는 함수.
        {
            System.Console.Out.Write("학번: ");
            this.num = Console.ReadLine();
            System.Console.Out.Write("이름: ");
            this.name = Console.ReadLine();
            System.Console.Out.Write("국어: ");
            this.kor = int.Parse(Console.ReadLine());
            System.Console.Out.Write("영어: ");
            this.eng = int.Parse(Console.ReadLine());
            System.Console.Out.Write("수학: ");
            this.math = int.Parse(Console.ReadLine());
            System.Console.Out.Write("C#: ");
            this.cs = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Student[] stu = new Student[5];
            int select = 100;
            while (select!=0)
            {
                System.Console.Out.WriteLine("1. 학생 입력");
                System.Console.Out.WriteLine("2. 리스트 출력");
                System.Console.Out.WriteLine("3. 성적 계산");
                System.Console.Out.WriteLine("4. 리스트 수정");
                System.Console.Out.WriteLine("5. 장학생");
                System.Console.Out.Write("메뉴를 선택하세요] ");
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        for (int i = 0; i < 5; i++) {
                            stu[i] = new Student(); // 학생 인스턴스를 생성한다.
                            stu[i].init(); // 학생 정보를 입력받는다.
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        System.Console.Out.WriteLine("잘못된 입력으로 종료합니다.");
                        select = 0;
                        break;
                }
            }
        }
    }
}
