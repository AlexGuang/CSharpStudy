using System;

namespace HelloWorld1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring a variable
            int num1;
            // assigning a value to variable
            num1 = 13;

            int num2 = 23;
            int sum = num1 + num2;
            Console.WriteLine("num1 " + num1 + " + num2 " + num2 +" =  sum " + sum);
            Console.WriteLine("num1 is " + num1);
            int num3, num4, num5;


            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is : " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is :" + fDiv);

            Console.Read();
        }
    }
}
