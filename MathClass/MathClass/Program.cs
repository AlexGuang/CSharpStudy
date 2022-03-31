using System;

namespace MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling:{0}",Math.Ceiling(19.6));
            Console.WriteLine("Floor:{0}", Math.Floor(19.6));


            int num1 = 23;
            int num2 = 5;
            Console.WriteLine("Lower of num1: {0} and num2: {1} is :{2}",num1,num2,Math.Min(num1,num2));
            Console.WriteLine("Higher of num1: {0} and num2 {1} is {2}", num1, num2, Math.Max(num1, num2));


            Console.WriteLine("----------------------------------");
            Console.WriteLine("3 to the power of 5 is：{0}",Math.Pow(3,5 ));
            Console.WriteLine("Value of the PI is: {0}",Math.PI);
            Console.WriteLine("=======================================");

            Console.WriteLine("The square root of {0} is：{1}", 25, Math.Sqrt(25));
            Console.WriteLine("Always positive is:{0}",Math.Abs(-26.35));
            Console.WriteLine("Cos of 1 is: {0}",Math.Cos(1));
        }
    }
}
