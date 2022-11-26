using System;
namespace MethodDemo
{
    public class RandomClassDemo
    {
        static void Main2()
        {
            

            Random random = new Random();
            int[] arr = new int[6]; //데이터 6개
            int temp = 0;   //데이터를 담아 둘 임시 변수

            for (int i = 0; i < 6; i++) //6번 반복한다 
            {
                temp = random.Next(45) + 1; //1 ~ 45
                bool flag = false;  //중복 상태값

                
                Console.WriteLine("temp는 {0} ", temp);

                if (i > 0 && i <6)  //첫번째 i는 생략하고 두번째 i부터 해당된다 
                {
                    for (int j = 0; j < i; j++)    //5번 반복한다 
                    {
                        Console.Write("arr[j]는 {0} /", arr[j]);

                        if (arr[j] == temp) 
                        {
                            flag = true;    //중복되면 true 
                        }
                    }
                }
                Console.WriteLine();

                if (flag)
                {
                    --i;    //중복되었다면 현재 인덱스를 재반복한다 
                }
                else
                {
                    arr[i] = temp;  //중복된 데이터가 없다면 저장한다 
                }

            }

            Console.Write("이번 주의 로또 : ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();


        }
    }
}

