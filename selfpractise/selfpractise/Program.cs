
using System;

namespace selfpractise
{
    class Program
    {
        //{
        //    public delegate void Test(string t);
        //public delegate void Calculate(int a, int b);
        static void Main(string[] args)
        {
            Action<int,int> action = Sum;
            action += Difference;
            action += Divide;
            action += Multiply;
            action(10, 5);


        }

        //    Test test = Print1;
        //    test += Print2;
        //    test += Print3;
        //    //test.Invoke();
        //    test("106");
        //}
        //static void Print1(string text)
        //{
        //    Console.WriteLine("Salam1"+text);
        //}
        //static void Print2(string text)
        //{
        //    Console.WriteLine("Salam2"+text);
        //}
        //static void Print3(string text)
        //{
        //    Console.WriteLine("Salam3"+text);
        //}

        //    Calculate calculate = new Calculate(Sum);
        //    calculate += Difference;
        //    calculate += Divide;
        //    calculate += Multiply;
        //    calculate(10, 5);
        //
        ////}
        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Difference(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Test(string test)
        {
            Console.WriteLine(test);
        }
    }

}


