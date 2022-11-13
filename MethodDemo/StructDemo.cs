using System;

struct Point
{
    public int X;
    public int Y;
}

struct Product
{
    public int Id;
    public string Title;
    public decimal Price;
}

struct BusinessCard
{
    public string Name;
    public int Age;
}

class StructDemo
{
    static StructDemo()
    {
        Point point;    //Point 구조체 형식의 변수 선언
        point.X = 100;  //점으로 구분해서 X변수에 값을 할당
        point.Y = 200;
        Console.WriteLine($"X : {point.X}, Y : {point.Y}");

        Product product;
        product.Id = 1; //구조체 변수의 각 멤버에 값을 할당
        product.Title = "좋은 책";
        product.Price = 10000M;

        //구조체 형식 변수 사용
        string message = $"번호 : {product.Id}\n상품명 : {product.Title}\n가격 : {product.Price}";
        Console.WriteLine(message);

        BusinessCard biz;
        biz.Name = "백승수";
        biz.Age = 20;
        Print(biz.Name, biz.Age);

        BusinessCard[] names = new BusinessCard[2]; //구조체 형식 배열 선언
        names[0].Name = "이세영"; names[0].Age = 30;
        names[1].Name = "권경민"; names[1].Age = 40;
        for (int n = 0; n < names.Length; n++)
        {
            Print(names[n].Name, names[n].Age);
        }

        //Print 함수에 구조체 변수인 product를 전달 
        Print(product);

        //날짜 관련 내장 구조체 
        Console.WriteLine($"현재 시간 : {DateTime.Now}");


    }

    /// <summary>
    /// 구조체 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    static void Print(string name, int age) => Console.WriteLine($"{name}은 {age}입니다.");

    static void Print(Product product) => Console.WriteLine($"{product.Title}은 {product.Price}입니다.");

}
