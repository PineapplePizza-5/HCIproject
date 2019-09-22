using System;

namespace ConsoleApp1
{
    class P1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫번째 숫자를 입력하세요 : ");
            int Value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("연산자를 입력하세요 (+,-,*,/): ");
            char Operate = char.Parse(Console.ReadLine());

            Console.WriteLine("두번째 숫자를 입력하세요 : ");
            int Value2 = int.Parse(Console.ReadLine());

            double result=0;
            bool error = false;
            switch (Operate)
            {
                case '+':
                    result = Value1 + Value2;
                    break;
                case '-':
                    result = Value1 - Value2;
                    break;
                case '*':
                    result = Value1 * Value2;
                    break;
                case '/':
                    if (Value2 != 0)
                        result = (double)(Value1 / Value2);
                    else
                        error = true;
                    break;
                default:
                    error = true;
                    break;
            }

            if(!error)
                Console.WriteLine("{0} {1} {2} = {3}", Value1, Operate, Value2, result);
            else
                Console.WriteLine("에러입니다");

        }
    }
}
