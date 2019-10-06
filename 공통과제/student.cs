using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HCI_GradeManagementProgram
{

    class Student
    {
        String num, name; // num: 학번 , name: 이름
        int kor, eng, math, cs; // 각 과목별 점수
        int total; // total: 총점
        float evg; // evg: 평균(소숫점 한자리까지만 출력)
        char korGrade, engGrade, mathGrade, csGrade; // 어쩌구Grade : 과목별 학점(A, B, C, D, F)
        int rank;   //rank : 등수



        void init() // 학생 정보(학번, 이름, 각 과목별 점수)를 입력받는 함수.
        {
            System.Console.Out.WriteLine("");

            System.Console.Out.Write("학번> ");
            this.num = Console.ReadLine();
            System.Console.Out.Write("이름> ");
            this.name = Console.ReadLine();

            System.Console.Out.WriteLine("");

            System.Console.Out.Write("국어 성적> ");
            this.kor = int.Parse(Console.ReadLine());
            System.Console.Out.Write("영어 성적> ");
            this.eng = int.Parse(Console.ReadLine());
            System.Console.Out.Write("수학 성적> ");
            this.math = int.Parse(Console.ReadLine());
            System.Console.Out.Write("  C# 성적> ");
            this.cs = int.Parse(Console.ReadLine());

            System.Console.Out.WriteLine("");
        }


        void calculate()    //학생의 총점과 평균 계산, 과목별 학점 부여
        {
            this.total = this.kor + this.eng + this.math + this.cs;
            this.evg = this.total / 4;

            switch ((int)this.kor / 10)
            {
                case 10:
                case 9:
                    this.korGrade = 'A'; break;
                case 8:
                    this.korGrade = 'B'; break;
                case 7:
                    this.korGrade = 'C'; break;
                case 6:
                    this.korGrade = 'D'; break;
                default:
                    this.korGrade = 'F'; break;

            }
            switch ((int)this.eng / 10)
            {
                case 10:
                case 9:
                    this.engGrade = 'A'; break;
                case 8:
                    this.engGrade = 'B'; break;
                case 7:
                    this.engGrade = 'C'; break;
                case 6:
                    this.engGrade = 'D'; break;
                default:
                    this.engGrade = 'F'; break;

            }
            switch ((int)this.math / 10)
            {
                case 10:
                case 9:
                    this.mathGrade = 'A'; break;
                case 8:
                    this.mathGrade = 'B'; break;
                case 7:
                    this.mathGrade = 'C'; break;
                case 6:
                    this.mathGrade = 'D'; break;
                default:
                    this.mathGrade = 'F'; break;

            }
            switch ((int)this.cs / 10)
            {
                case 10:
                case 9:
                    this.csGrade = 'A'; break;
                case 8:
                    this.csGrade = 'B'; break;
                case 7:
                    this.csGrade = 'C'; break;
                case 6:
                    this.csGrade = 'D'; break;
                default:
                    this.csGrade = 'F'; break;

            }
        }

        void view()         //학생정보 출력
        {
            System.Console.Out.WriteLine("\n======================================================================");

            System.Console.Out.Write("\t");
            System.Console.Out.Write("이름) {0}", this.name);

            System.Console.Out.Write("\t");
            System.Console.Out.Write("   학번) {0}", this.num);

            System.Console.Out.WriteLine("");

            System.Console.Out.WriteLine("======================================================================");

            System.Console.Out.Write("\t\t");
            System.Console.Out.Write("과목");

            System.Console.Out.Write("\t\t");
            System.Console.Out.Write("성적");

            System.Console.Out.Write("\t\t");
            System.Console.Out.Write("학점");

            System.Console.Out.WriteLine("\n======================================================================\n");

            System.Console.Out.Write("\t\t");
            System.Console.Out.Write("국어");
            System.Console.Out.Write("\t\t");
            System.Console.Out.Write("{0}점", this.kor);
            System.Console.Out.Write("\t\t");
            System.Console.Out.Write(" {0}\n", this.korGrade);

            System.Console.Out.Write("\t\t");
            System.Console.Out.Write("영어");
            System.Console.Out.Write("\t\t");
            System.Console.Out.Write("{0}점", this.eng);
            System.Console.Out.Write("\t\t");
            System.Console.Out.Write(" {0}\n", this.engGrade);

            System.Console.Out.Write("\t\t");
            System.Console.Out.Write("수학");
            System.Console.Out.Write("\t\t");
            System.Console.Out.Write("{0}점", this.math);
            System.Console.Out.Write("\t\t");
            System.Console.Out.Write(" {0}\n", this.mathGrade);

            System.Console.Out.Write("\t\t");
            System.Console.Out.Write("  C#");
            System.Console.Out.Write("\t\t");
            System.Console.Out.Write("{0}점", this.cs);
            System.Console.Out.Write("\t\t");
            System.Console.Out.Write(" {0}\n", this.csGrade);

            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("======================================================================");

            System.Console.Out.Write("\t");
            System.Console.Out.Write("등수) {0}등", this.rank);

            System.Console.Out.Write("\t");
            System.Console.Out.Write("   총점) {0}점", this.total);

            System.Console.Out.Write("\t");
            System.Console.Out.Write("   평균) {0:f1}", this.evg);


            System.Console.Out.WriteLine("");
            System.Console.Out.WriteLine("");

        }




        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>();
            int select = 100, stuNum = 5;

            int mod_sel = 100;//수정 내부 메뉴
            int modNum;//수정할 학생 번호
            int addNum;//삽입할 위치

            while (select != 0)
            {
                System.Console.Out.WriteLine("===== M E N U =====");
                System.Console.Out.WriteLine("1. 학생 정보 입력");
                System.Console.Out.WriteLine("2. 리스트 출력");
                System.Console.Out.WriteLine("3. 성적 계산");
                System.Console.Out.WriteLine("4. 리스트 수정");
                System.Console.Out.WriteLine("5. 장학생");
                System.Console.Out.WriteLine("6. 정보 삭제");

                System.Console.Out.WriteLine("");

                System.Console.Out.Write("메뉴를 선택하세요> ");
                select = int.Parse(Console.ReadLine());

                System.Console.Out.WriteLine("");

                switch (select)
                {
                    case 1:
                        for (int i = 1; i <= stuNum; i++)
                        {
                            Student temp = new Student(); // 임시 학생 인스턴스를 생성한다. (입력용)

                            System.Console.Out.WriteLine("\n>>> {0}번째 학생에 대한 정보를 입력하세요! <<<", i);
                            temp.init();    // 학생 정보를 입력받는다.
                            stu.Add(temp);  // 리스트에 학생을 추가한다.
                        }
                        stuNum = stu.Count(); // 학생 수 저장

                        break;

                    case 2:
                        if (!stu.Any())     //입력된 학생 정보가 없을 경우 안내문 출력
                        {
                            System.Console.Out.WriteLine("\n<< 입력된 학생 정보가 없습니다.>>\n");
                        }
                        else
                        {
                            for (int i = 0; i < stuNum; i++)
                            {
                                stu[i].view();      //학생 정보를 출력한다.
                            }
                        }
                        break;

                    case 3:
                        if (!stu.Any())     //입력된 학생 정보가 없을 경우 안내문 출력
                        {
                            System.Console.Out.WriteLine("\n<< 입력된 학생 정보가 없습니다.>>\n");
                        }
                        else
                        {
                            for (int i = 0; i < stuNum; i++)
                            {
                                stu[i].calculate(); //학생의 총점과 평균을 계산한다.
                            }
                            System.Console.Out.WriteLine("\n<<학점 계산이 정상적으로 완료되었습니다>>\n");
                        }
                        break;
                    case 4:
                        Student temp_mod = new Student();
                        System.Console.Out.WriteLine("1. 수정\n2. 추가\n3. 삽입\n");
                        mod_sel = int.Parse(Console.ReadLine());
                        switch (mod_sel)
                        {
                            case 1:
                                System.Console.Out.WriteLine("수정할 학생의 번호 입력하세요 : ");
                                modNum = int.Parse(Console.ReadLine());
                                if (modNum > 0 && modNum <= stuNum)
                                {
                                    System.Console.Out.WriteLine("정보를 수정하세요\n");

                                    temp_mod.init();    // 학생 정보를 입력받는다.
                                    stu[modNum - 1] = temp_mod;//수정한 정보로 덮어쓰기
                                }
                                else
                                    System.Console.Out.WriteLine("잘못된 입력입니다.\n");//예외처리
                                break;
                            case 2:
                                System.Console.Out.WriteLine("추가할 학생의 정보를 입력하세요 : ");

                                temp_mod.init();    // 학생 정보를 입력받는다.
                                stu.Add(temp_mod);  // 리스트에 학생을 추가한다.
                                stuNum++;//출력할 학생 수 +1 하기
                                break;
                            case 3:
                                System.Console.Out.WriteLine("삽입할 위치를 입력하세요 : ");
                                addNum = int.Parse(Console.ReadLine());
                                if (addNum > 0 && addNum <= stuNum)
                                {
                                    System.Console.Out.WriteLine("삽입할 학생의 정보를 입력하세요 : ");

                                    temp_mod.init();    // 학생 정보를 입력받는다.
                                    stu.Insert(addNum - 1, temp_mod);//입력받은 정보 삽입하기
                                    stuNum++;//출력할 학생 수 +1 하기
                                }
                                else
                                    System.Console.Out.WriteLine("잘못된 입력입니다.\n");//예외처리
                                break;
                        }
                        break;

                    case 5:
                        {
                            if (!stu.Any())     //입력된 학생 정보가 없을 경우 안내문 출력
                            {
                                System.Console.Out.WriteLine("\n<< 입력된 학생 정보가 없습니다.>>\n");
                            }

                            bool exist = stu.Exists(delegate (Student A) {
                                if (A.total != '\0') return true;
                                else return false;
                            });      // 총점이 계산되었을 때만 등수를 볼 수 있게 한다.

                            if (exist != false)
                            {
                                stu.Sort(delegate (Student a, Student b)
                                {  // 리스트의 학생 총점을 기준으로 내림차순 정렬한다.
                                    if (a.total > b.total) return -1;
                                    else if (a.total < b.total) return 1;
                                    return 0;
                                });


                                if (!stu.Any())     //입력된 학생 정보가 없을 경우 안내문 출력
                                {
                                    System.Console.Out.WriteLine("\n<< 입력된 학생 정보가 없습니다.>>\n");
                                }
                                else
                                {
                                    for (int k = 0; k < stu.Count; k++)
                                    {
                                        stu[k].rank = k + 1;    // 학생 객체에 등수값을 넣어준다
                                        System.Console.Out.WriteLine("{0}등 : {1} - 총점 {2} \n", k + 1, stu[k].name, stu[k].total);
                                        //정렬한 값(등수)를 출력한다.

                                    }

                                    System.Console.Out.WriteLine("이번 장학생은 \n");  // 1등부터 3등까지 장학생을 출력한다
                                    for (int k = 0; k < 3; k++)
                                    {
                                        System.Console.Out.WriteLine("{0} \n", stu[k].name);
                                    }
                                    System.Console.Out.WriteLine("입니다. 축하합니다. \n");
                                }

                            }
                            else
                            {  // 총점이 계산되지 않은 경우, 안내문 출력
                                System.Console.Out.WriteLine("\n<< 총점이 계산되지 않았습니다.>>\n");
                                System.Console.Out.WriteLine("<< 총점을 먼저 계산해 주세요.>>\n");
                            }
                            break;
                        }

                    case 6:
                        {
                            if (stu.Any())
                            {
                                System.Console.Out.WriteLine("삭제할 학생의 이름을 적어주세요 : \n");
                                String findName = Console.ReadLine();
                                for (int i = 0; i < stuNum; i++)
                                {
                                    if (stu[i].name == findName)
                                    {
                                        stu[i].view();
                                        System.Console.Out.WriteLine("\n삭제할 정보가 위 정보가 맞습니까?\t1. 예\t2. 아니오 : ");
                                        int sel = int.Parse(Console.ReadLine());
                                        switch (sel)
                                        {
                                            case 1:
                                                stu.RemoveAt(i);
                                                stuNum--;
                                                break;
                                            case 2:
                                                System.Console.Out.WriteLine("메뉴로 돌아갑니다.\n");
                                                break;
                                            default:
                                                System.Console.Out.WriteLine("값을 잘못 입력하셨습니다.");
                                                break;
                                        }
                                        
                                    }
                                    else
                                        continue;
                                }
                            }
                            else
                                System.Console.Out.WriteLine("삭제할 학생정보가 없습니다.\n");
                            
                            break;
                        }
                        


                    default:
                        System.Console.Out.WriteLine("잘못된 입력으로 종료합니다.");
                        select = 0;
                        break;

                }
            }
        }
    }


}