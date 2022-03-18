using System;

namespace MethodPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(145, 23);
            Console.WriteLine(result);

            //or I can just put the ADD() into the writeline()
            Console.WriteLine(Add(145,23)); // A method can be called in the bracket of console . write line

            //I also can call the Add() method in the Add()method itself.
            Console.WriteLine(Add(Add(2, 3), Add(30, 24)));

            Console.WriteLine(Product(32, 543));

            Console.WriteLine(Divide(3532,243));


            Console.ReadLine();

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;

        }

        public static int Product(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
