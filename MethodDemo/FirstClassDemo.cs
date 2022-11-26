using System;
namespace MethodDemo
{
    public class FirstClassDemo
    {
        /*
         * 클래스 내 맴버를 구성할 때 static이 붙으면 정적 멤버가 되고 static이 붙지 않으면 인스턴트 멤버가 된다 
         */
        static void StaticMethod() => Console.WriteLine("1. 정적 메서드 ");

        void InstanceMethod() => Console.WriteLine("2. 인스턴스 메서드 ");

        static void Main1()
        {

            FirstClassDemo.StaticMethod();  //1.정적 메서드 호출

            FirstClassDemo demo = new FirstClassDemo();     //2.인스턴스 메서드 호출
            demo.InstanceMethod();

            

        }
    }
}

