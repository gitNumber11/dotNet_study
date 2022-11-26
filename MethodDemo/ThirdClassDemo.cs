using System;
namespace MethodDemo
{
    public class ThirdClassDemo
    {
        static void Main4()
        {


            /*
             * throw 구문으로 직접 예외 발생
             * 인위적으로 예외 (에러) 발생시킨다 
             */
            try
            {
                Console.WriteLine("예외가 발생할 만한 구문 ");

                //Exception 클래스에 에러 메시지를 지정하여 무조건 에러 발생 
                //throw new Exception(); //무작정 에러 발생 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("예외가 발생하든 하지 않든 간에 실행된다 ");
            }





        }
    }
}

