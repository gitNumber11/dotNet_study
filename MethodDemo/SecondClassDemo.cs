using System;
using System.Text;

namespace MethodDemo
{
    public class SecondClassDemo
    {
        static void Main3()
        {
            void IsWhat(object o)
            {
                /*
                 * is 연산자로 특정 형식인지 체크할 수 있다 
                 */
                if (o is int)
                {
                    Console.WriteLine("Int");
                }
                else if (o is string)
                {
                    Console.WriteLine("String");
                }
                else if (o is DateTime)
                {
                    Console.WriteLine("DateTime");
                }
            }

            IsWhat(1234);
            IsWhat("Hello");
            IsWhat(DateTime.Now);


            /*
             * String 클래스에 문자 배열을 전달하면 문자열로 변환 가능하다 
             */
            char[] charArray = { 'A', 'B', 'C' };
            String str = new string(charArray);
            Console.WriteLine(str);

            /*
             * String.Concat() 메서드를 사용하여 문자열 연결 
             */
            string str1 = "안녕" + "하세요 ";
            string str2 = String.Concat("반갑" + "습니다 ");
            Console.WriteLine($"{str1} {str2}");

            /*
             * 문자열을 묶는 세 가지 방법 
             * 1. 더하(+) 연산자 사용
             * 2. string.Format(), String.Format() 사용 
             * 3. 문자열 보간법 사용 
             */
            var firstName = "승수";
            var lastName = "백";
            Console.WriteLine($"이름 : {lastName}{firstName}");


            /*
             * string.IsNullOrWhiteSpace() 메서드는 빈 (Empty)과 null 값 
             * 추가로 "공백" 까지 처리한다 ==> "", " ", "\r"
             */


            /*
             * 메서드 체이닝으로 StringBuilder 클래스의 여러 메서드 호출 
             */
            var message = new StringBuilder()
                .AppendFormat("{0} 클래스를 사용한 ", nameof(StringBuilder))
                .Append("메서드 ")
                .Append("체이닝 ")
                .ToString()
                .Trim();
            Console.WriteLine(message);

            /*
             * StringBuilder 클래스 사용하기 
             */
            StringBuilder sb = new StringBuilder();
            sb.Append("StringBuilder 클래스 ");

        }

       
    }
}

