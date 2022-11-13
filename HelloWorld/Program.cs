using System;

namespace HelloWorld
{
    class HelloWorld
    {
        //svm +Tab 두번 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //cw + Tab 두번

            Console.Write("줄 바꿈 \n");
            Console.WriteLine("줄 바꿈 포함");

            Console.WriteLine("{0}", "자리표시자 또는 서식 지정자 ");

            Console.WriteLine(1234);    //정수 리터럴 
            Console.WriteLine(3.14F);   //실수 리터럴    
            Console.WriteLine("A");     //문자 리터럴 
            Console.WriteLine("Hello"); //문자열 리터럴 

            string multiLines = @"
                안녕하세요.
                @ 기호로 여러 줄 문자열을 저장합니. 
            ";
            Console.WriteLine(multiLines);

            string message = "Hello. 문자열 보간법 또는 문자열 템플릿 ";
            Console.WriteLine($"{message}");

            int number = 3;
            string result = "홀수 ";
            Console.WriteLine($"{number}은 {result}");

            //Console.ReadLine(); //<-이 시점에서 대기하는 효과 

            string strNumber = "1234";
            int number1 = Convert.ToInt32(strNumber);
            int number2 = int.Parse(strNumber);
            int number3 = Int32.Parse(strNumber);

            Console.WriteLine($"{number1.GetType()}");
            Console.WriteLine($"{number2.GetType()}");
            Console.WriteLine($"{number3.GetType()}");

            //이진수
            Console.WriteLine(Convert.ToString(10, 2)); //Convert.ToString(숫자 , 2);
            Console.WriteLine(Convert.ToString(5, 2));

            Console.WriteLine(Convert.ToString(5, 2).PadLeft(4, '0'));
            //PadLeft(숫자 , '0');

            int dec = 1_0000_0000;  //1,000,000
            Console.WriteLine(dec);


            //기본 데이터 형식의 TryParse() 메서드로 형식 변환이 가능한지 판단
            string data = "1234";
            int outResult;

            if (int.TryParse(data, out outResult))
            {
                Console.WriteLine("변환 가능 : {0}", outResult);
            }

            if (int.TryParse(data, out var outVar))
            {
                Console.WriteLine("out var 형식 : {0}", outVar);
            }

            //1차원 배열 선언 및 초기화
            int[] intArray;         //1차원 배열 선언 
            intArray = new int[2];  //메모리 영역 확보(0,1)

            intArray[0] = 1;        //배열 초기화 
            intArray[1] = 2;

            foreach (var item in intArray)
            {
                Console.WriteLine($"intArray 배열 :{item}");
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"intArray 배열 {i}번째 인덱스 : {intArray[i]}");
            }

            //1차원 배열 선언, 요소 생성, 초기화 동시에
            int[] intArray1 = new int[2] { 1, 2 };

            foreach (int item in intArray1)
            {
                Console.WriteLine("{0}", item);
            }

            //new 키워드와 int[] 생략하고 바로 초기화 가능
            int[] intArray2 = { 1, 2 };

            foreach (var item in intArray2)
            {
                Console.WriteLine(item);
            }

            //2차원 배열 생성 및 반복문 사용
            int[,] intTwoArray;             //2치원 배열 선언
            intTwoArray = new int[2, 3];    //1*2개의 요소 생성
            intTwoArray[0, 0] = 1;          //2차원 배열 초기화 
            intTwoArray[0, 1] = 2;
            intTwoArray[0, 2] = 3;
            intTwoArray[1, 0] = 4;
            intTwoArray[1, 1] = 5;
            intTwoArray[1, 2] = 6;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{intTwoArray[i, j]}_");
                }
                Console.Write("\n");
            }

            //함수란? 어떤 값을 받아서 그 값을 가지고 가공을 거져 어떤 결과값을 반환
            Show(); //Show() 메서드 호출

            //매개변수(인수, 파라미터)가 있는 함수
            ShowMessage("parameter");

            //반환값이 있는 함수 호출 
            string retrunValue = GetString();
            Console.WriteLine(retrunValue);

            //XML문서 주석 사용
            int a = 3;
            int b = 5;
            int c = AddNumbers(a, b);

            //기본 매개변수
            StringLog("기본 매개변수 ");
            StringLog("기본 매개변수 ", 4);

            //화살표 함수 , 람다식
            ArrowFunction();

            //로컬 함수 만들기 : 로컬 함수란 ? 함수 내에서만 사용하는 또 다른 함수를 만드는 것 
            int LocalAdd(int a, int b) => a * b;

            //로컬 함수 사용하기 
            Console.WriteLine($"3 + 5 = {LocalAdd(3, 5)}");


        }

        static void Show() //Show() 메서드(함수)
        {
            Console.WriteLine("Show Method");
        }


        static void ShowMessage(string message) //매개변수가 있는 함수 
        {
            Console.WriteLine(message); //넘어온 매개변수 값을 출력 
        }

        static string GetString()
        {
            return "반환(Return Value)";  //return 키워드로 단순 문자열 반환 
        }

        /// <summary>
        /// 두 수를 더하여 그 결과값을 반환시켜 주는 함수 
        /// </summary>
        /// <param name="a">첫 번째 매개 변수 </param>
        /// <param name="b">두 번째 매개 변수 </param>
        /// <returns>a + b 결과 </returns>
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// 기본 매개변수 예제 함수 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="level">기본 매개변수, 선택적 인수 </param>
        static void StringLog(string message, byte level = 1)
        {
            Console.WriteLine($"{message}, {level}");
        }

        /// <summary>
        /// 화살표 함수, 람다 식(lambda expression)
        /// </summary>
        static void ArrowFunction() => Console.WriteLine("화살표 함수 => ");

    }
}
