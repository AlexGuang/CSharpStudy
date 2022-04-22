using System;

namespace GenericTypeMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Show(123);
            Show("haha");
            Show(3232.245);
            Show1<int>();



        }

        public static void Show<T>(T param)//当参数使用
        {
            Console.WriteLine(param.GetType().Name);
        }

        public static T Show1<T>()//当返回值使用
        {
            return default(T);
        }
        public static void show2<T>()//当局部变量使用
        {
            T t;
        }
    }
}
